package com.example.giovanellispizzaria;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Home extends Activity {

	TextView historico;
	TextView pedido;
	Button botao;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		
		botao = (Button) findViewById(R.id.btnCentral);
		pedido = (TextView) findViewById(R.id.txtDetalhes);
		historico = (TextView) findViewById(R.id.txtHistorico);		
		
		
		pedido.setOnClickListener
		(
			new View.OnClickListener()
			{
				public void onClick(View v)
				{
					Context context = getApplicationContext();
					Intent i = new Intent(context, DetalhePedido.class);
					startActivity(i);
				}
			}
		);
		
		historico.setOnClickListener
		(
			new View.OnClickListener()
			{
				public void onClick(View v)
				{
					Context context = getApplicationContext();
					Intent i = new Intent(context, Historico.class);
					startActivity(i);
				}
			}
		);
	}

	  
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
