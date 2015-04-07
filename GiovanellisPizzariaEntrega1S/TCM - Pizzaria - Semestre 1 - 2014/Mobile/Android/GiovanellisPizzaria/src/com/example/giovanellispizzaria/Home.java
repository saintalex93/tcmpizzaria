package com.example.giovanellispizzaria;

import java.util.List;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.text.DynamicLayout;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.TextView;
import android.widget.Toast;

public class Home extends Activity {

	Context context = this;
	
	TextView historico;
	TextView pedido;
	
//	int pedidos = 4;
	
	 //ListView list;
	 //private List<String> List_file;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		
		pedido = (TextView) findViewById(R.id.txtDetalhes);
		historico = (TextView) findViewById(R.id.txtHistorico);		
		
		pedido.setOnLongClickListener
		(
			new View.OnLongClickListener()
			{
				public boolean onLongClick(View v)
				{
					AlertDialog.Builder alertDialog2 = new AlertDialog.Builder(
					        context);

					// Setting Dialog Title
					alertDialog2.setTitle("Finalizar pedido");

					alertDialog2.setMessage("Esse pedido foi...");

					alertDialog2.setPositiveButton
					("Cancelado",
					        new DialogInterface.OnClickListener() 
							{
									public void onClick(DialogInterface dialog, int which) 
					            	{
					                // Write your code here to execute after dialog
					                Toast.makeText(getApplicationContext(),
					                        "O pedido foi marcado CANCELADO.", Toast.LENGTH_SHORT)
					                        .show();
					                dialog.cancel();
					            	}
					        }
						);
					
					alertDialog2.setNegativeButton
					("Entregue",
					        new DialogInterface.OnClickListener() 
							{
					            public void onClick(DialogInterface dialog, int which) 
					            {
					                // Write your code here to execute after dialog
					                Toast.makeText(getApplicationContext(),
					                		"O pedido foi marcado ENTREGUE.", Toast.LENGTH_SHORT)
					                        .show();
					            }
					        }
					);

					alertDialog2.show();
					
					return true;
				}
			}
		);
		
		pedido.setOnClickListener
		(
			new View.OnClickListener()
			{
				public void onClick(View v)
				{
					/*					
					Context context = getApplicationContext();
					Intent i = new Intent(context, DetalhePedido.class);
					startActivity(i);
					*/
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
