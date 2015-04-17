package com.example.giovanellispizzaria;

import java.io.BufferedInputStream;
import java.io.InputStream;
import java.net.URL;
import java.net.URLConnection;
import java.sql.Date;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Random;

import android.os.Bundle;
import android.os.Debug;
import android.app.Activity;
import android.app.AlertDialog;
import android.content.DialogInterface;
import android.graphics.Color;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;


public class Historico extends Activity {

	ListView historico;
	
	Random r = new Random();
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_historico);
		
		try 
		{
			historico = (ListView) findViewById(R.id.lstHistorico);
			
			final ArrayList<String> arrayHistorico = new ArrayList<String>();
			
			ArrayAdapter<String> adapter = new ArrayAdapter<String>
			(
				this,
				android.R.layout.simple_list_item_1, 
				arrayHistorico
			);
			
			String texto = "", aux = "";
			try {
				// ATENÇÃO A REDE DEVE ESTAR FUNCIONANDO COM O ENDEREÇO IP
				// OK

				// IP do curso
				// URL url = new
				// URL("http://10.67.74.32/default_consulta.aspx");

				// IP de casa

				URL url = new URL(
						"http://192.168.1.14/Giovanellis/consulta_listaPedidosAEntregar.aspx?Cod_Funcionario=" + Login.codFuncionario);

				URLConnection conexao = url.openConnection();

				Log.i("Input sozinho", conexao.getInputStream().toString());

				InputStream inputStream = conexao.getInputStream();

				BufferedInputStream bufferedInput = new BufferedInputStream(
						inputStream);
				int current = 0;

				while ((current = bufferedInput.read()) != -1) {
					texto = texto + ((char) (byte) current + "");
				}

				inputStream.close();

				// INÍCIO DA SEPARAÇÃO DOS
				// REGISTROS############################

				int tamanho = texto.length();
				int numeroRegistro = 0;
				int qtdProdutos = 0;
				int coluna = 0;
				
				boolean achou = false;
				

				String endereço = "";
				String mensagem = "";
				
				
				
				for (int i = 0; i < tamanho; i++) 
				{
					if (texto.charAt(i) == '#') {
						achou = true;
						i++;
					}

					if (texto.charAt(i) == '^')
						achou = false;

					if (achou) 
					{
						
						if (texto.charAt(i) != ';' && texto.charAt(i) != ',')
							aux = aux + texto.charAt(i);
						else if (texto.charAt(i) == ',')
						{
							numeroRegistro++;
							endereço = aux;
							aux = "";
						}
						else if (texto.charAt(i) == ';')
						{
							qtdProdutos = Integer.parseInt(aux);

							aux = "";
							
							coluna = 0;
							
							mensagem = numeroRegistro + "- " + endereço + " (" + qtdProdutos;
							
							if(qtdProdutos > 1)
								mensagem += " produtos)";
							else
								mensagem += " produto)";
							
							arrayHistorico.add(mensagem);
						}
					}
				}
				// FIM DA SEPARAÇÃO DOS
				// REGISTROS##################################
			}
			catch (Exception e) 
			{
				Log.d("asdf", "Message: " + e.getMessage());
				Log.d("asdf",
						"Localized message: " + e.getLocalizedMessage());
				Log.d("InputStream", "Message: " + e.getMessage()
						+ " - Resto dos erros:", e);
			}
			
			historico.setAdapter(adapter);
	        
			
			
/*			for(int i = 0; i < 20; i++)
			{
				arrayHistorico.add(Home.endereco + " - " + Home.qtdProdutos + " produtos - 19/6 - 19:32");
				
			}
	*/			
			adapter.notifyDataSetChanged();
			
			AlertDialog.Builder builderFinalizado = new AlertDialog.Builder(this);
			
			builderFinalizado.setMessage("Gostaria de marcar esse pedido como [estadoOposto]?");
			builderFinalizado.setCancelable(true);
			builderFinalizado.setPositiveButton
	        (
	    		"Sim", new DialogInterface.OnClickListener() 
	    		{
	    			public void onClick(DialogInterface dialog, int id) 
	    			{
	    				dialog.cancel();
	    			}
	    		}
			);
	        
			builderFinalizado.setNegativeButton
	        (
				"Não", new DialogInterface.OnClickListener() 
				{
					public void onClick(DialogInterface dialog, int id) 
					{
						dialog.cancel();
					}
				}
			);

			try
			{
				ArrayAdapter<String> adapterColor = new ArrayAdapter<String>(
			            this,android.R.layout.simple_list_item_1, arrayHistorico){
					
					@Override
					public View getView(int position, View convertView, ViewGroup parent) {
					    View view = super.getView(position, convertView, parent);
					    TextView text = (TextView) view.findViewById(android.R.id.text1);
					    int x = r.nextInt(5);
					    if( x == 0)
					    {
					      text.setTextColor(Color.RED);
					    }   
					    else
					    {
					    	text.setTextColor(Color.rgb(0, 200, 50));
					    }
					    return view;
					  }
			    };
			        
			        historico.setAdapter(adapterColor);
			}
			catch (Exception e)
			{
				
			}
			
	        final AlertDialog alertFinalizado = builderFinalizado.create();
	        
	        historico.setOnItemLongClickListener
			(
				new AdapterView.OnItemLongClickListener() 
				{
				    @Override
				    public boolean onItemLongClick(AdapterView<?> av, View v, int pos, long id) 
				    {
				    	alertFinalizado.show();	
				    	return true;
				    }
				}
			);
	        
		}
		catch (Exception e)
		{
			Log.d("Historico",e.toString());
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.historico, menu);
		return true;
	}

}
