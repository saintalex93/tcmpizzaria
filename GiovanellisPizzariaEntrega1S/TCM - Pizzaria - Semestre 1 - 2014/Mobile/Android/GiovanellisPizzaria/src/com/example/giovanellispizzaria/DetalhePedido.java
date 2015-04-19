package com.example.giovanellispizzaria;

import java.io.BufferedInputStream;
import java.io.InputStream;
import java.net.URL;
import java.net.URLConnection;
import java.util.ArrayList;
import java.util.Random;

import android.net.Uri;
import android.os.Bundle;
import android.app.Activity;
import android.content.ActivityNotFoundException;
import android.content.Context;
import android.content.Intent;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.TextView;

public class DetalhePedido extends Activity {

	TextView detalhesPedido;
	TextView tituloPedido;
	TextView pagamento;
	TextView troco;
	TextView nomeCliente;
	TextView valorHora;
	
	Button btnResidencial;
	Button btnCelular;

	ListView produtos;
	
	String NomeClienteString = "";
	String celular = "";
	String telefone = "";
	String hora = "";
	String FormaDepagamentoString = "";

	double valorPedido = 0;
	double valorPago = 0;
	
	final ArrayList<String> arrayProdutos = new ArrayList<String>();
	
	Random r = new Random();
	
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_detalhe_pedido);

		try
		{
			btnCelular = (Button) findViewById(R.id.btnCel);
			btnResidencial = (Button) findViewById(R.id.btnRes);
			
			tituloPedido = (TextView) findViewById(R.id.txtTituloPedido);
			detalhesPedido = (TextView) findViewById(R.id.txtDetalhes);
			pagamento = (TextView) findViewById(R.id.txtPagamento);
			troco = (TextView) findViewById(R.id.txtTroco);
			nomeCliente = (TextView) findViewById(R.id.txtNome);
			valorHora = (TextView) findViewById(R.id.txtHoraPreco);
			
			buscaDetalhesPedido();
			
			detalhesPedido.setText(Home.enderecoCompleto);
			
			nomeCliente.setText(NomeClienteString);
			
			valorHora.setText(hora + " - R$ " + valorPedido);
			
			String produtosPreco = "";
			produtosPreco = String.valueOf(Home.qtdeProdutos) + " produto";
			
			if(Home.qtdeProdutos > 1)
				produtosPreco += "s";

			tituloPedido.setText(produtosPreco);
		
			produtos = (ListView) findViewById(R.id.lstProdutos);
			
			ArrayAdapter<String> adapter2 = new ArrayAdapter<String>
			(
				this,
				android.R.layout.simple_list_item_1,
				arrayProdutos
			);
			
				produtos.setAdapter(adapter2);

				preencheProdutos();
				
				adapter2.notifyDataSetChanged();
				
				btnCelular.setOnClickListener
				(
						new View.OnClickListener()
						{
							public void onClick(View v)
							{
								try {
				                    Intent callIntent = new Intent(Intent.ACTION_CALL);
				                    callIntent.setData(Uri.parse("tel: +55 "+ celular));
				                    startActivity(callIntent);
				                } catch (ActivityNotFoundException e) {
				                    Log.d("Calling a Phone Number", e.getLocalizedMessage());
				                }
							}
						}
					);
				
				btnResidencial.setOnClickListener
				(
						new View.OnClickListener()
						{
							public void onClick(View v)
							{
								try {
				                    Intent callIntent = new Intent(Intent.ACTION_CALL);
				                    callIntent.setData(Uri.parse("tel: +55 "+ telefone));
				                    startActivity(callIntent);
				                } catch (ActivityNotFoundException e) {
				                    Log.d("Calling a Phone Number", e.getLocalizedMessage());
				                }
							}
						}
					);
		}
		catch(Exception e)
		{
			Log.d("Detalhes Pedido", e.getLocalizedMessage());
		}
		
		
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.detalhe_pedido, menu);
		return true;
	}

	void preencheProdutos()
	  {
		arrayProdutos.clear();
		  
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
						"http://192.168.1.14/Giovanellis/consulta_Detalhes_listaProdutos.aspx?CodPedido=" + Home.codPedido);

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
					{
						if (texto.charAt(i) != ';' && texto.charAt(i) != ',')
							aux = aux + texto.charAt(i);
						else
						{
							arrayProdutos.add(aux);
							aux = "";
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
	  }

	void buscaDetalhesPedido()
	{
		String texto = "", aux = "";
		try {
			// ATENÇÃO A REDE DEVE ESTAR FUNCIONANDO COM O ENDEREÇO IP
			// OK

			// IP do curso
			// 10.67.74.32
			
			// IP de casa
			//192.168.1.14

			URL url = new URL(
					"http://192.168.1.14/Giovanellis/consulta_Detalhes_selectFormaPagamento.aspx?CodPedido=" + Home.codPedido);

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
			int coluna = 0;
			
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
				{
					if (texto.charAt(i) != ';' && texto.charAt(i) != '.')
							aux = aux + texto.charAt(i);	
					
					else if (texto.charAt(i) == '.' || texto.charAt(i) == ';')
					{
						switch(coluna)
						{
						case 0:
							FormaDepagamentoString = aux;
							break;
							
						case 1:
							valorPedido = Double.parseDouble(aux.replace(',', '.'));
							break;
							
						case 2:
							valorPago = Double.parseDouble(aux.replace(',', '.'));
							break;
							
						case 3:
							hora = aux.substring(0, 5);
							break;
							
						case 4:
							NomeClienteString = aux;
							break;
							
						case 5:
							celular = aux.replace("-", "");
							break;
							
						case 6:
							telefone = aux.replace("-", "");
							break;
						}
						aux = "";
						
						coluna++;
					}
					
					if(texto.charAt(i) == ';')
					{
						if(FormaDepagamentoString.equals("Dinheiro"))
							troco.setText(FormaDepagamentoString + " - R$ " + valorPago + " (Troco: R$ " + (valorPago - valorPedido) + ")");

						else
							troco.setText(FormaDepagamentoString);
						
						if(telefone.length() == 0)
							btnResidencial.setEnabled(false);
					
						if(celular.length() == 0)
							btnCelular.setEnabled(false);
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
	}
}
