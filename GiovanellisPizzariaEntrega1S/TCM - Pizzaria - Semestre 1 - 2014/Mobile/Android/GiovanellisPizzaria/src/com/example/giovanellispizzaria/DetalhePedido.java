package com.example.giovanellispizzaria;

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
	
	Button nomeCliente;

	ListView produtos;
	
	Random r = new Random();
	
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_detalhe_pedido);

		try
		{
			nomeCliente = (Button) findViewById(R.id.btnCliente);
			tituloPedido = (TextView) findViewById(R.id.txtTituloPedido);
			detalhesPedido = (TextView) findViewById(R.id.txtDetalhes);
			pagamento = (TextView) findViewById(R.id.txtPagamento);
			troco = (TextView) findViewById(R.id.txtTroco);
			
			detalhesPedido.setText(Home.enderecoCompleto);
			
			int formaDePagamento = r.nextInt(3);
			
			switch(formaDePagamento)
			{
				case 0:
					troco.setText("Cartão");
					break;
					
				case 1:
					troco.setText("Cheque");
					break;
					
				case 2:
					troco.setText("Dinheiro - R$ 60,00 (Troco: R$ 5,27)");
					break;
			}
			
			
			
			String produtosPreco = "";
			produtosPreco = String.valueOf(Home.qtdProdutos) + " produto";
			
			if(Home.qtdProdutos > 1)
				produtosPreco += "s";

			tituloPedido.setText(produtosPreco);
		
			produtos = (ListView) findViewById(R.id.lstProdutos);

			final ArrayList<String> arrayProdutos = new ArrayList<String>();
			
			ArrayAdapter<String> adapter2 = new ArrayAdapter<String>
			(
				this,
				android.R.layout.simple_list_item_1,
				arrayProdutos
			);
			
			
				produtos.setAdapter(adapter2);

				int j = r.nextInt(6)+1;
				
				Log.d("Home", j+"");
				
				for(int i = 0; i <  j ; i++)
					arrayProdutos.add("Pizza " + (i+1));

				adapter2.notifyDataSetChanged();
				
				
				
				
				nomeCliente.setOnClickListener
				(
						new View.OnClickListener()
						{
							public void onClick(View v)
							{
								try {
				                    Intent callIntent = new Intent(Intent.ACTION_CALL);
				                    callIntent.setData(Uri.parse("tel: +55 (11) 989361878"));
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

}
