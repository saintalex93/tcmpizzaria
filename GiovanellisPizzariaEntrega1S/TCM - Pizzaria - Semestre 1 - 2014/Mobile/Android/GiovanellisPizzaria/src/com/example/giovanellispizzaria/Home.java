package com.example.giovanellispizzaria;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.lang.reflect.Array;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import java.util.ArrayList;
import java.util.Random;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.os.Debug;
import android.os.StrictMode;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Adapter;
import android.widget.AdapterView;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.widget.Toast;

public class Home extends Activity {

	Context context;
	
	TextView historico;
	TextView pedido;
	TextView user;
	
	ListView pedidos;
	
	String alertMessage = "";
	
	public static String endereco;

	public static int qtdProdutos;
	public static int codPedidoDesfecho;
	
	ArrayList<String> arrayPedidos = new ArrayList<String>();
	
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);

		StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
		StrictMode.setThreadPolicy(policy);
		
		user = (TextView) findViewById(R.id.txtUser);
		
		user.setText(Login.nomeFuncionario);
		
		Random r = new Random();
		
		context = getApplicationContext();
		
		historico = (Button) findViewById(R.id.btnHistorico);
		
		pedidos = (ListView) findViewById(R.id.lstPedidos);
		
		AlertDialog.Builder builder1 = new AlertDialog.Builder(this);
			
		final ArrayAdapter<String> adapter = new ArrayAdapter<String>
		(
			this,
			android.R.layout.simple_list_item_1, 
			arrayPedidos
		);
		
		builder1.setMessage("Marcar esse pedido como...");

		builder1.setCancelable(true);
        
        builder1.setPositiveButton("Realizado", new DialogInterface.OnClickListener() 
    		{
    			public void onClick(DialogInterface dialog, int id) 
    			{
    				URL url;
					try 
					{
						url = new URL("http://192.168.1.14/Giovanellis/update_RealizarPedido.aspx?Cod_Pedido=" + codPedidoDesfecho);
						
						URLConnection conexao = url.openConnection();

						InputStream inputStream = conexao.getInputStream();
						
					} catch (MalformedURLException e) {
						Log.d("URL_CancelaPedido",e.getLocalizedMessage());
					} catch (IOException e) {
						Log.d("URL_CancelaPedido",e.getLocalizedMessage());
					}

					//TODO: Atualizar lista de pedidos para que o pedido finalizado seja removido da lista
					
					Toast.makeText(getApplicationContext(), "Pedido #" + codPedidoDesfecho + " foi marcado como 'REALIZADO'." , Toast.LENGTH_SHORT).show();
					
					updatePedidos();
					
					adapter.notifyDataSetChanged();
					
					dialog.cancel();
    			}
    		}
		);
        
        builder1.setNegativeButton("Cancelado", new DialogInterface.OnClickListener() 
			{
				public void onClick(DialogInterface dialog, int id) 
				{
					URL url;
					try 
					{
						url = new URL("http://192.168.1.14/Giovanellis/update_CancelarPedido.aspx?Cod_Pedido=" + codPedidoDesfecho);
						
						URLConnection conexao = url.openConnection();

						InputStream inputStream = conexao.getInputStream();
						
					} catch (MalformedURLException e) {
						Log.d("URL_CancelaPedido",e.getLocalizedMessage());
					} catch (IOException e) {
						Log.d("URL_CancelaPedido",e.getLocalizedMessage());
					}

					//TODO: Atualizar lista de pedidos para que o pedido finalizado seja removido da lista
					
					Toast.makeText(getApplicationContext(), "Pedido #" + codPedidoDesfecho + " foi marcado como 'CANCELADO'." , Toast.LENGTH_SHORT).show();
					
					updatePedidos();
					
					adapter.notifyDataSetChanged();
					
					dialog.cancel();
				}
			}
		);
        
        final AlertDialog alert11 = builder1.create();
		
		pedidos.setAdapter(adapter);
        
		updatePedidos();
		
		adapter.notifyDataSetChanged();

		pedidos.setOnItemClickListener(new OnItemClickListener() 
		{
			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int position,
					long arg3) {
				
				Intent i = new Intent(context, DetalhePedido.class);
				startActivity(i);
			}
		}
		);
		
		pedidos.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() 
			{
			    @Override
			    public boolean onItemLongClick(AdapterView<?> av, View v, int pos, long id) 
			    {
			    	codPedidoDesfecho = Integer.parseInt(arrayPedidos.get(pos).substring(1, 2));
			    	
			    	alert11.show();	
			    	
			    	return true;
			    }
			}
		);

			historico.setOnClickListener
			(
			new View.OnClickListener()
			{
				public void onClick(View v)
				{
					Intent i = new Intent(context, Historico.class);
					startActivity(i);
				}
			}
		);
	}

	  void updatePedidos()
	  {
		  arrayPedidos.clear();
		  
		  String texto = "", aux = "";
			try {
				// ATENÇÃO A REDE DEVE ESTAR FUNCIONANDO COM O ENDEREÇO IP
				// OK

				// IP do curso
				// 10.67.74.32
				
				// IP de casa
				//192.168.1.14

				// IP de casa

				URL url = new URL(
						"http://192.168.1.14/Giovanellis/consulta_listaPedidosAEntregar.aspx?Cod_Funcionario=" + Login.codFuncionario);

				URLConnection conexao = url.openConnection();

				InputStream inputStream = conexao.getInputStream();

				BufferedInputStream bufferedInput = new BufferedInputStream(inputStream);

				int current = 0;

				while ((current = bufferedInput.read()) != -1) 
				{
					texto = texto + ((char) (byte) current + "");
				}

				inputStream.close();

				// INÍCIO DA SEPARAÇÃO DOS
				// REGISTROS############################

				int tamanho = texto.length();
				int numeroPedido = 0;
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
							coluna++;
							
							switch(coluna)
							{
							case 1:
								numeroPedido = Integer.parseInt(aux);
								break;
								
							case 2:
								endereço = aux;
								break;
								
							case 3:
								qtdProdutos = Integer.parseInt(aux);
							}
							
							
							aux = "";
						}
						else if (texto.charAt(i) == ';')
						{
							qtdProdutos = Integer.parseInt(aux);

							aux = "";
							
							coluna = 0;
							
							mensagem = "#" + numeroPedido + " - " + endereço + " (" + qtdProdutos;
							
							if(qtdProdutos > 1)
								mensagem += " produtos)";
							else
								mensagem += " produto)";
							
							arrayPedidos.add(mensagem);
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
	  }
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
