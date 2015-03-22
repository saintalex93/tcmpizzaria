package com.example.giovanellispizzaria;

import android.app.Activity;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.widget.TextView;

public class Home extends Activity {

	TextView saudacao;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_home);
		
		//final String tag = "Home";
		
	//	 saudacao = (TextView)findViewById(R.string.saudacao_home);
	
//			Log.d(tag, saudacao.getText(saudacao.setText(saudacao.getText() + "Roberto")));
		 
//		 saudacao.setText(saudacao.getText() + "Roberto");

	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.home, menu);
		return true;
	}

}
