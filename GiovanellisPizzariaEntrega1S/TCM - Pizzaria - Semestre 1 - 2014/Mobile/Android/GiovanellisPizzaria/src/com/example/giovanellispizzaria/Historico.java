package com.example.giovanellispizzaria;

import java.sql.Date;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Random;

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


public class Historico extends Activity {

	ListView historico;
	
	Random r = new Random();
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_historico);
		
		try 
		{
			historico = (ListView) findViewById(R.id.lstHistorico);
			
			final ArrayList<String> arrayHistorico = new ArrayList<String>();
			
			ArrayAdapter<String> adapter = new ArrayAdapter<String>
			(
				this,
				android.R.layout.simple_list_item_1, 
				arrayHistorico
			);
			
			historico.setAdapter(adapter);
	        
			
			
			for(int i = 0; i < 20; i++)
			{
				arrayHistorico.add(Home.endereco + " - " + Home.qtdProdutos + " produtos - 19/6 - 19:32");
				
				
	//			if(r.nextInt(1) == 0)
//					historico.getChildAt(i).sett
				
			}
				
			adapter.notifyDataSetChanged();
			
			AlertDialog.Builder builderFinalizado = new AlertDialog.Builder(this);
			
			builderFinalizado.setMessage("Gostaria de marcar esse pedido como [estadoOposto]?");
			builderFinalizado.setCancelable(true);
			builderFinalizado.setPositiveButton
	        (
	    		"Sim", new DialogInterface.OnClickListener() 
	    		{
	    			public void onClick(DialogInterface dialog, int id) 
	    			{
	    				dialog.cancel();
	    			}
	    		}
			);
	        
			builderFinalizado.setNegativeButton
	        (
				"Não", new DialogInterface.OnClickListener() 
				{
					public void onClick(DialogInterface dialog, int id) 
					{
						dialog.cancel();
					}
				}
			);

			try
			{
				ArrayAdapter<String> adapterColor = new ArrayAdapter<String>(
			            this,android.R.layout.simple_list_item_1, arrayHistorico){
					
					@Override
					public View getView(int position, View convertView, ViewGroup parent) {
					    View view = super.getView(position, convertView, parent);
					    TextView text = (TextView) view.findViewById(android.R.id.text1);
					    int x = r.nextInt(5);
					    if( x == 0)
					    {
					      text.setTextColor(Color.RED);
					    }   
					    else
					    {
					    	text.setTextColor(Color.rgb(0, 200, 50));
					    }
					    return view;
					  }
			    };
			        
			        historico.setAdapter(adapterColor);
			}
			catch (Exception e)
			{
				
			}
			
	        final AlertDialog alertFinalizado = builderFinalizado.create();
	        
	        historico.setOnItemLongClickListener
			(
				new AdapterView.OnItemLongClickListener() 
				{
				    @Override
				    public boolean onItemLongClick(AdapterView<?> av, View v, int pos, long id) 
				    {
				    	alertFinalizado.show();	
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

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.historico, menu);
		return true;
	}

}
