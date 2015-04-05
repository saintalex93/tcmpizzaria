package com.example.giovanellispizzaria;

import java.util.ArrayList;
import java.util.Random;

import android.os.Bundle;
import android.app.Activity;
import android.content.Context;
import android.util.Log;
import android.view.Menu;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.TextView;

public class DetalhePedido extends Activity {

	TextView detalhesPedido;
	TextView nomeHora;
	TextView tituloPedido;
	
	ListView produtos;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_detalhe_pedido);
		
		Random r = new Random();
		
		detalhesPedido = (TextView) findViewById(R.id.txtDetalhes);
		nomeHora = (TextView) findViewById(R.id.txtNomeClienteEHora);
		tituloPedido = (TextView) findViewById(R.id.txtTituloPedido);
		detalhesPedido.setText(detalhesPedido.getText() + Home.endereco);
		
		String produtosPreco = "";
		produtosPreco = String.valueOf(Home.qtdProdutos) + " produto";
		
		if(Home.qtdProdutos > 1)
			produtosPreco += "s";

		produtosPreco += " - R$ 54,73";
		
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

			for(int i = 0; i < Home.qtdProdutos; i++)
				arrayProdutos.add("Pizza " + (i+1));

			adapter2.notifyDataSetChanged();
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.detalhe_pedido, menu);
		return true;
	}

}
