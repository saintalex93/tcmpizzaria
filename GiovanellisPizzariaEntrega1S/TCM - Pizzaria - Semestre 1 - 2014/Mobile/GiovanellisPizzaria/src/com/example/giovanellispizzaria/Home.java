package com.example.giovanellispizzaria;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class Home extends Activity {

	TextView saudacao;
	Button botao;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		
		Button btn = (Button) findViewById(R.id.button1);

		TextView text = (Button) findViewById(R.id.txtSaudacao);
		
		text.setText(text.getText().toString() + " Roberto!");
		
		btn.setOnClickListener(new View.OnClickListener() {

		    public void onClick(View v) {
		        myClick(v); /* my method to call new intent or activity */
		    }
		    
		    public void myClick(View v) {
		    	 
		    }
		});
		
		//final String tag = "Home";
		
		
		 
		

	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
