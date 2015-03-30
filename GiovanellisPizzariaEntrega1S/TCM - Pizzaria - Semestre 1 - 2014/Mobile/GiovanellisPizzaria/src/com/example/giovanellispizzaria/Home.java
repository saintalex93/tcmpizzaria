package com.example.giovanellispizzaria;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Home extends Activity {

	TextView saudacao;
	Button botao;
	TextView pedido;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		
		botao = (Button) findViewById(R.id.central);

		saudacao = (TextView) findViewById(R.id.Pedidos);
		
/*		pedido.setOnClickListener
		(
			new View.OnClickListener()
			{
				public void OnClick(View v)
				{
					
				}
			}
		);
	*/	
		botao.setOnClickListener
		(
			new View.OnClickListener() 
			{
            	public void onClick(View v) 
        		{
        			saudacao.setText("Hello word");
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
