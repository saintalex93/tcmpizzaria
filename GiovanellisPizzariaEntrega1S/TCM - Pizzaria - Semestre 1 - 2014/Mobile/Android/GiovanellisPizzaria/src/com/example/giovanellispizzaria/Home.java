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

import org.apache.http.util.ByteArrayBuffer;

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
	
	public static String enderecoCompleto = "";

	public static int qtdeProdutos;
	public static int codPedido;
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
		
		codPedido = 0;
		
		builder1.setMessage("Marcar esse pedido como...");

		builder1.setCancelable(true);
        
        builder1.setNegativeButton("Realizado", new DialogInterface.OnClickListener() 
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

					Toast.makeText(getApplicationContext(), "Pedido #" + codPedidoDesfecho + " foi marcado como 'REALIZADO'." , Toast.LENGTH_SHORT).show();
					
					updatePedidos();
					
					adapter.notifyDataSetChanged();
					
					dialog.cancel();
    			}
    		}
		);
        
        builder1.setPositiveButton("Cancelado", new DialogInterface.OnClickListener() 
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

		pedidos.setOnItemClickListener
		(new OnItemClickListener() 
		{
			@Override
			public void onItemClick
			(
				AdapterView<?> arg0, 
				View arg1, 
				int position,
				long arg3
			)
			{
				 
				
				Intent intent = new Intent(context, DetalhePedido.class);
				startActivity(intent);
			}
		}
		);
		
		pedidos.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() 
			{
			    @Override
			    public boolean onItemLongClick(AdapterView<?> av, View v, int pos, long id) 
			    {
			    	if(arrayPedidos.get(pos).toString().charAt(0) != 'N')
			    	{
			    		int i = 1;
				    	String numero = "";
			    		
			    		while(arrayPedidos.get(pos).toString().charAt(i) != ' ')
				    	{
				    		numero += arrayPedidos.get(pos).toString().charAt(i);
				    		i++;
				    	}

				    	codPedidoDesfecho = Integer.parseInt(numero);
				    	
				    	alert11.show();	
			    	}

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

				ByteArrayBuffer byteArray = new ByteArrayBuffer(1);
				
				int current = 0;
				
				while((current = bufferedInput.read()) != -1)
					byteArray.append((byte)current);

				texto = new String(byteArray.toByteArray());

				inputStream.close();

				// INÍCIO DA SEPARAÇÃO DOS
				// REGISTROS############################

				int tamanho = texto.length();
				int numeroPedido = 0;
				int qtdProdutos = 0;
				int coluna = 0;
				
				boolean achou = false;

				String endereco = "";
				String numRes = "";
				String numAp = "";
				
				
				String enderecoAlt = "";
				String numResAlt = "";
				String numApAlt = "";
				
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
								endereco = aux;
								break;
								
							case 3:
								numRes = aux;
								break;
								
							case 4:
								numAp = aux;
								break;

							case 5:
								qtdProdutos = Integer.parseInt(aux);
								break;
								
							case 6:
								enderecoAlt = aux;
								break;
								
							case 7:
								numResAlt = aux;
								break;
								
							}
							
							/*TODO: 
							 * Essa linha foi colocada aqui, porque o algoritmo acima, quando achava um ponto e virgula (;)
							 * partia para o próximo campo, sem inserir o valor de aux à numApAlt, fazendo o número alternativo
							 * do apartamento não aparecer.
							 * 
							 * Ficar ligado nisso aqui...
							*/
							numApAlt = aux;
							
							aux = "";
						}
						else if (texto.charAt(i) == ';')
						{
							coluna = 0;
							
							if(enderecoAlt.length() == 0)
							
								if(numAp.length() == 0)
									mensagem = "#" + numeroPedido + " - " + endereco + ", "+ numRes + " (" + qtdProdutos + ")";
								else
									mensagem = "#" + numeroPedido + " - " + endereco + ", "+ numRes + ", Ap: " + numAp +" (" + qtdProdutos + ")";

							else
								
								if(numApAlt.length() == 0)
									mensagem = "#" + numeroPedido + " - " + enderecoAlt + ", "+ numResAlt + " (" + qtdProdutos + ")";
								else
									mensagem = "#" + numeroPedido + " - " + enderecoAlt + ", "+ numResAlt + ", Ap: " + numApAlt +" (" + qtdProdutos + ")";
								
							aux = "";
							enderecoAlt = "";
							numResAlt = "";
							numApAlt = "";
							
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
			}
			
			if(arrayPedidos.size() == 0)
				arrayPedidos.add("Não há nenhum pedido pendente");
	  }
	
	  void pegaEndereco(int position)
	  {
		  enderecoCompleto = "";
		  
		  boolean comeco = false;
			boolean fim = false;
			int i = 0;

			while((arrayPedidos.get(position).charAt(i) != '('))
			{
				if(arrayPedidos.get(position).charAt(i) == '-')
				{
					comeco = true;
					i++;
				}

				if(comeco)
					enderecoCompleto += arrayPedidos.get(position).charAt(i);

				
				i++;
			}  
	  }
	  
	  int pegarCodEndereco(int position)
	  {
			int i = 1;
			
			String resultado = "";
			
			while ((arrayPedidos.get(position).charAt(i) != ' ')) 
			{
				resultado += arrayPedidos.get(position).charAt(i);

				i++;
			}

			return Integer.parseInt(resultado);
	  }
	  
	  int pegarQtdeProdutos(int position)
	  {
			int i = 1;
			
			boolean comeco = false;
			
			String resultado = "";
			
			while ((arrayPedidos.get(position).charAt(i) != ')')) 
			{
				if(arrayPedidos.get(position).charAt(i) == '(')
				{
					comeco = true;
					i++;
				}
				
				if(comeco)
					resultado += arrayPedidos.get(position).charAt(i);

				i++;
			}

			return Integer.parseInt(resultado);
	  }
	  
	  public static void meuLog(String tag, String mensagem)
	  {
		  Log.d(tag, "'" + mensagem + "'");
	  }
	  
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
