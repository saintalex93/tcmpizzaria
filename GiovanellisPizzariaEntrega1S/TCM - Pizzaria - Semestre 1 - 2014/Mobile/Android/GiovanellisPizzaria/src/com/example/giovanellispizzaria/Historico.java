package com.example.giovanellispizzaria;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLConnection;
import java.sql.Date;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Random;

import org.apache.http.util.ByteArrayBuffer;

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
import android.widget.Toast;


public class Historico extends Activity {

	ListView historico;
	
	Random r = new Random();
	
	ArrayList<String> arrayHistorico = new ArrayList<String>();
	
	String estadoPedido = "";
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_historico);
		
		try 
		{
			historico = (ListView) findViewById(R.id.lstHistorico);
			
			final ArrayAdapter<String> adapter = new ArrayAdapter<String>
			(
				this,
				android.R.layout.simple_list_item_1, 
				arrayHistorico
			)
			{
				@Override
				public View getView
				(
					int position,
					View convertView,
					ViewGroup parent
				) 
				{
					View view = super.getView(position, convertView, parent);

					TextView text = (TextView) view
							.findViewById(android.R.id.text1);

				    if(arrayHistorico.get(0).toString().charAt(0) == 'N')
				    	text.setTextColor(Color.BLACK);

				    else if(arrayHistorico.get(position).contains("Realizado"))
				    	text.setTextColor(Color.rgb(0, 200, 50));
				    
				    else if(arrayHistorico.get(position).contains("Cancelado"))
					      text.setTextColor(Color.RED);

					return view;
				}
			};
			
			
			historico.setAdapter(adapter);
	        
			updateHistorico();
			
			adapter.notifyDataSetChanged();
			
			AlertDialog.Builder builderFinalizado = new AlertDialog.Builder(this);
			
			builderFinalizado.setMessage("Marcar esse pedido como...");
			
			builderFinalizado.setCancelable(true);
			
			builderFinalizado.setPositiveButton
	        (
	    		"Cancelado", new DialogInterface.OnClickListener() 
	    		{
	    			public void onClick(DialogInterface dialog, int id) 
	    			{
	    				URL url;
						try 
						{
							url = new URL("http://192.168.1.8/Giovanellis/update_CancelarPedido.aspx?Cod_Pedido=" + Home.codPedidoDesfecho);
							
							URLConnection conexao = url.openConnection();

							InputStream inputStream = conexao.getInputStream();
							
						} catch (MalformedURLException e) {
							Log.d("URL_CancelaPedido",e.getLocalizedMessage());
						} catch (IOException e) {
							Log.d("URL_CancelaPedido",e.getLocalizedMessage());
						}

						Toast.makeText(getApplicationContext(), "Pedido #" + Home.codPedidoDesfecho + " foi marcado como 'CANCELADO'." , Toast.LENGTH_SHORT).show();
						
						updateHistorico();
						
						adapter.notifyDataSetChanged();
						
						dialog.cancel();
	    			}
	    		}
			);
	        
			builderFinalizado.setNegativeButton
	        (
				"Realizado", new DialogInterface.OnClickListener() 
				{
					public void onClick(DialogInterface dialog, int id) 
					{
						URL url;
						try 
						{
							url = new URL("http://192.168.1.8/Giovanellis/update_RealizarPedido.aspx?Cod_Pedido=" + Home.codPedidoDesfecho);
							
							URLConnection conexao = url.openConnection();

							InputStream inputStream = conexao.getInputStream();
							
						} catch (MalformedURLException e) {
							Log.d("URL_CancelaPedido",e.getLocalizedMessage());
						} catch (IOException e) {
							Log.d("URL_CancelaPedido",e.getLocalizedMessage());
						}

						Toast.makeText(getApplicationContext(), "Pedido #" + Home.codPedidoDesfecho + " foi marcado como 'REALIZADO'." , Toast.LENGTH_SHORT).show();
						
						updateHistorico();
						
						adapter.notifyDataSetChanged();
						
						dialog.cancel();
					}
				}
			);
			
	        final AlertDialog alertFinalizado = builderFinalizado.create();
	        
	        historico.setOnItemLongClickListener
			(
				new AdapterView.OnItemLongClickListener() 
				{
				    @Override
				    public boolean onItemLongClick(AdapterView<?> av, View v, int pos, long id) 
				    {
				    	if(arrayHistorico.get(pos).toString().charAt(0) != 'N')
				    	{
				    		int i = 1;
					    	String numero = "";
				    		
				    		while(arrayHistorico.get(pos).toString().charAt(i) != ' ')
					    	{
					    		numero += arrayHistorico.get(pos).toString().charAt(i);
					    		i++;
					    	}
					    	
					    	Home.codPedidoDesfecho = Integer.parseInt(numero);
					    	
					    	alertFinalizado.show();
				    	}

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

	void updateHistorico()
	{
		  arrayHistorico.clear();
		  
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
						"http://192.168.1.8/Giovanellis/consulta_listaHistorico.aspx?Cod_Funcionario=" + Login.codFuncionario);

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
				
				String data = "";
				String hora = "";
				
				String estado = "";
				
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
								data = aux;
								break;
								
							case 6:
								hora = aux;
								break	;							
								
							case 7:
								estado = aux;
								break;
								
							case 8:
								qtdProdutos = Integer.parseInt(aux);
								break;
								
							case 9:
								enderecoAlt = aux;
								break;
								
							case 10:
								numResAlt = aux;
								break;
								
							}
							
							/*TODO: 
							 * 
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
							
							data = formatarData(data);	
							
							String mensagemQtdeProdutos = qtdProdutos + " produto";

							if(qtdProdutos > 1)
								mensagemQtdeProdutos += "s";
							
							//Se NÃO tiver endereço alternativo
							if(enderecoAlt.length() == 0)
								if(numAp.length() == 0)
									mensagem = "#" + numeroPedido + "\n" + endereco + ", "+ numRes + "\n" + data + " - " + hora + "\n" + mensagemQtdeProdutos + " - " + estado;
								else
									mensagem = "#" + numeroPedido + "\n" + endereco + ", "+ numRes + ", Ap: " + numAp + "\n" + data + " - " + hora + "\n" + mensagemQtdeProdutos + " - " + estado;

							//Se TIVER endereço alternativo
							else
								
								if(numApAlt.length() == 0)
									mensagem = "#" + numeroPedido + "\n" + enderecoAlt + ", "+ numResAlt + "\n" + data + " - " + hora + "\n" + mensagemQtdeProdutos + " - " + estado;
								else
									mensagem = "#" + numeroPedido + "\n" + enderecoAlt + ", "+ numResAlt + ", Ap: " + numApAlt + "\n" + data + " - " + hora + "\n" + mensagemQtdeProdutos + " - " + estado;
								
							aux = "";
							enderecoAlt = "";
							numResAlt = "";
							numApAlt = "";
							
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
			
			if(arrayHistorico.size() == 0)
				arrayHistorico.add("Não há nenhum pedido no histórico");
	  }
	
	void pedidoRealizado(int codPedido)
	{
		String texto = "", aux = "";
		
		estadoPedido = "";
		
		try {
			// ATENÇÃO A REDE DEVE ESTAR FUNCIONANDO COM O ENDEREÇO IP
			// OK

			// IP do curso
			// 10.67.74.32
			
			// IP de casa
			//192.168.1.14

			// IP de casa

			URL url = new URL(
					"http://192.168.1.8/Giovanellis/consulta_estadoItemHistorico.aspx?Cod_Pedido=" + codPedido);

			URLConnection conexao = url.openConnection();

			InputStream inputStream = conexao.getInputStream();

			BufferedInputStream bufferedInput = new BufferedInputStream(inputStream);

			int current = 0;

			while ((current = bufferedInput.read()) != -1) 
				texto = texto + ((char) (byte) current + "");

			inputStream.close();

			// INÍCIO DA SEPARAÇÃO DOS
			// REGISTROS############################

			int tamanho = texto.length();
			
			boolean achou = false;

			for (int i = 0; i < tamanho; i++) 
			{
				if (texto.charAt(i) == '#') {
					achou = true;
					i++;
				}

				if (texto.charAt(i) == '^')
					achou = false;

				if (achou) 
					if (texto.charAt(i) != ';')
						aux = aux + texto.charAt(i);
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
		
		Log.d("aux",aux);
		
		estadoPedido = aux;
		
		Log.d("estadoPedido", estadoPedido);
	}
	
	String formatarData(String dataOriginal)
	{
/*		Log.d("formatarData", "DEU");
		
		String aux = "";
		String ano = "";
		String mes = "";
		String dia = "";
		String resultado = "";
		
		try
		{
			int coluna = 0;

			for(int i = 0; i <= dataOriginal.length(); i++)
			{
				if(dataOriginal.charAt(i) != '-')
				{
					aux += String.valueOf(dataOriginal.charAt(i));
					Log.d("aux", aux);
				}
				else if(dataOriginal.charAt(i) == '-')
				{
					Log.d("else", "dataOriginal.charAt(i) == '-'");
					
					if(ano.length() == 0)
					{
						ano = aux;	
						Log.d("ano", ano);
					}
					else if (mes.length() == 0)
					{
						mes = aux;
						Log.d("mes", mes);
					}

					dia = aux;
					aux = "";					
					*/
		
					/*
					switch(coluna)
					{
						case 0:
							ano = aux;
							Log.d("case 0", ano);
							break;
						
						case 1:
							mes = aux;
							Log.d("case 1", mes);
					}
					
					coluna++;
					*/
		/*
				}

				
			}
		}
		catch(Exception e)
		{
			Log.d("formatarData - Try", e.getMessage());
		}*/
		
		String newDate = "";
		
		for(int i = 0; i < dataOriginal.length();i++)
			if(dataOriginal.charAt(i) == '-')
				newDate += "/";
			else
				newDate += dataOriginal.charAt(i);
		
		return newDate;
	}
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.historico, menu);
		return true;
	}

}
