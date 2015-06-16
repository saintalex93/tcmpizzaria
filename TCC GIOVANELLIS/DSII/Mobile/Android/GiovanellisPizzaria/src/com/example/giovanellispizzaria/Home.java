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
//import android.os.StrictMode;
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
	
	Button user;
	
	ListView pedidos;
	
	String alertMessage = "";
	
	String[] dadosPedido = null;
	
	
	ArrayList<String[]> arrayObjetos = new ArrayList<String[]>();
	
	ArrayList<String> arrayPedidos = new ArrayList<String>();

	public static String enderecoCompleto = "";
	public static String qtdeProdutos;
	public static String codPedido;
	public static String codPedidoDesfecho;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);

	//	StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
//		StrictMode.setThreadPolicy(policy);
		
		user = (Button) findViewById(R.id.txtUser);
		
		user.setText(Login.nomeFuncionario);
		
		Random r = new Random();
		
		context = getApplicationContext();
		
//		historico = (Button) findViewById(R.id.btnHistorico);
		
		pedidos = (ListView) findViewById(R.id.lstPedidos);
		
		AlertDialog.Builder builder1 = new AlertDialog.Builder(this);
			
		final ArrayAdapter<String> adapter = new ArrayAdapter<String>
		(
			this,
			android.R.layout.simple_list_item_1, 
			arrayPedidos
		);
		
		user.setOnClickListener
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
		
		codPedido = "";
		
		builder1.setMessage("Marcar esse pedido como...");

		builder1.setCancelable(true);
        
        builder1.setNegativeButton("Realizado", new DialogInterface.OnClickListener() 
    		{
    			public void onClick(DialogInterface dialog, int id) 
    			{
    				URL url;
					try 
					{
						Log.d("Login.ip",Login.ip);
						url = new URL("http://"+ Login.ip +"/Giovanellis/update_RealizarPedido.aspx?Cod_Pedido=" + codPedidoDesfecho);
						
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
						url = new URL("http://"+ Login.ip +"/Giovanellis/update_CancelarPedido.aspx?Cod_Pedido=" + codPedidoDesfecho);
						
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
				if(arrayPedidos.get(position).toString().charAt(0) != 'N')
				{
					codPedido = arrayObjetos.get(position)[0];
					enderecoCompleto = arrayObjetos.get(position)[2];
		            qtdeProdutos = arrayObjetos.get(position)[1];
	
		            Intent i = new Intent(context, DetalhePedido.class);
					startActivity(i);
				}
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
				    	codPedidoDesfecho = arrayObjetos.get(pos)[0];
				    	
				    	alert11.show();	
			    	}

			    	return true;
			    }
			}
		);

/*		historico.setOnClickListener
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
-*/	}

	void updatePedidos()
	  {
		  arrayPedidos.clear();
		  arrayObjetos.clear();
		  
		  String texto = "", aux = "";
			try {
				// ATENÇÃO A REDE DEVE ESTAR FUNCIONANDO COM O ENDEREÇO IP
				// OK

				URL url = new URL(
						"http://"+ Login.ip +"/Giovanellis/consulta_listaPedidosAEntregar.aspx?Cod_Funcionario=" + Login.codFuncionario);

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
						if (texto.charAt(i) != ';' )
							aux = aux + texto.charAt(i);

						else
						{
							dadosPedido = aux.split(",");
							
							try
							{
								
								arrayPedidos.add(getMensagem(dadosPedido));
								
								arrayObjetos.add(getObjeto(dadosPedido));

								aux = "";
								
								dadosPedido = null;	
							}
							catch(Exception e)
							{
								Log.d("try preenchimento arrays", "I got an error", e);
							}
							
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
	
	String[] getObjeto(String[] dadosPedido)
	{
		String[] objeto = new String[3];
		
		for(int i = 0; i < objeto.length; i++)
			objeto[i] = "";

			//Código do pedido do objeto
			objeto[0] = dadosPedido[0];

			//Pegar quantidade de produtos no pedido
			objeto[1] = dadosPedido[4];
			
			//Pegando endereço do cliente
			if(dadosPedido.length <= 5)
			{
				objeto[2] += dadosPedido[1] + ", "+ dadosPedido[2];
				
				
				//Se tiver apartamento, adicionar
				if(dadosPedido[3].length() > 0)
					objeto[2] += ", Ap: " + dadosPedido[3];
			}
			//Se pedido vier com endereço alternativo, pegar no lugar do endereço do cliente
			else if(dadosPedido.length > 5)
			{
				objeto[2] += dadosPedido[5] + ", "+ dadosPedido[6];

				//Se tiver apartamento, adicionar
				if(dadosPedido.length == 8)
					if(dadosPedido[7].length() > 0)
						objeto[2] += ", Ap: " + dadosPedido[7];
			}

		return objeto;
	}
	
	String getMensagem(String[] dadosPedido)
	{
		String mensagem = "";
		
		//Pegar mensagem de quantidade de produtos
		String mensagemQtdeProdutos = dadosPedido[4] + " produto";

		if(Integer.parseInt(dadosPedido[4]) > 1)
			mensagemQtdeProdutos += "s";
		
		mensagem = "#" + dadosPedido[0] + " - " + mensagemQtdeProdutos + "\n";
		
		//Pegando endereço do cliente
		if(dadosPedido.length <= 5)
		{
			mensagem += dadosPedido[1] + ", "+ dadosPedido[2];
			
			
			//Se tiver apartamento, adicionar
			if(dadosPedido[3].length() > 0)
				mensagem += ", Ap: " + dadosPedido[3];
		}
		//Se pedido vier com endereço alternativo, pegar no lugar do endereço do cliente
		else if(dadosPedido.length > 5)
		{
			mensagem += dadosPedido[5] + ", "+ dadosPedido[6];

			if(dadosPedido.length == 8)
				if(dadosPedido[7].length() > 0)
					mensagem += ", Ap: " + dadosPedido[7];
		}
		
		return mensagem;
	}
	
	int getQtdeProdutos(int position)
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
		  Log.e(tag, "'" + mensagem + "'");
	  }
	  
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
