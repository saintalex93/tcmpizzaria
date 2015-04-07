package com.example.giovanellispizzaria;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Random;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.os.Debug;
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
	
	ListView pedidos;
	
	String alertMessage = "";
	
	public static String nomePedido;
	public static String endereco;
	public static int qtdProdutos;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		
		Random r = new Random();
		
		context = getApplicationContext();
		
		historico = (Button) findViewById(R.id.btnHistorico);
		
		pedidos = (ListView) findViewById(R.id.lstPedidos);
		
		AlertDialog.Builder builder1 = new AlertDialog.Builder(this);
		
		builder1.setMessage("Marcar esse pedido como...");
        builder1.setCancelable(true);
        builder1.setPositiveButton
        (
    		"Entregue", new DialogInterface.OnClickListener() 
    		{
    			public void onClick(DialogInterface dialog, int id) 
    			{
    				dialog.cancel();
    			}
    		}
		);
        
        builder1.setNegativeButton
        (
			"Cancelado", new DialogInterface.OnClickListener() 
			{
				public void onClick(DialogInterface dialog, int id) 
				{
					dialog.cancel();
				}
			}
		);

        final AlertDialog alert11 = builder1.create();

		final ArrayList<String> arrayPedidos = new ArrayList<String>();
		
		ArrayAdapter<String> adapter = new ArrayAdapter<String>
		(
			this,
			android.R.layout.simple_list_item_1, 
			arrayPedidos
		);
		
		pedidos.setAdapter(adapter);
        
		for(int i = 0; i < (r.nextInt(10)+1); i++)
		{
			endereco = "Endereço " + (i+1);
			qtdProdutos = (r.nextInt(5)+1);
			arrayPedidos.add( (i+1) + "- " + endereco + " - " + qtdProdutos  + " produtos");
		}
			
		
		adapter.notifyDataSetChanged();
		
		pedidos.setOnItemClickListener(new OnItemClickListener() {

			@Override
			public void onItemClick(AdapterView<?> arg0, View arg1, int position,
					long arg3) {
				
				nomePedido = arrayPedidos.get(position).toString().substring(3);
				
				Intent i = new Intent(context, DetalhePedido.class);
				startActivity(i);
				
			}
		});

		pedidos.setOnItemLongClickListener
		(
			new AdapterView.OnItemLongClickListener() 
			{
			    @Override
			    public boolean onItemLongClick(AdapterView<?> av, View v, int pos, long id) 
			    {
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

	  
	
	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
