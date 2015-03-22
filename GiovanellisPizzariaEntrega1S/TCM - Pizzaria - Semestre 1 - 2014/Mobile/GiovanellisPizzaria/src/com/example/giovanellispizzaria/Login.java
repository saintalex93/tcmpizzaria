package com.example.giovanellispizzaria;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;

public class Login extends Activity {

	
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_login);
		
		Button login = (Button) findViewById(R.id.btnLogin);
			login.setOnClickListener(new OnClickListener()
			{
				  public void onClick(View v)
			      {
					  Context context = getApplicationContext();
					  
					  Intent i = new Intent(context, Home.class);
					  startActivity(i);
			      }
			}
		);
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.login, menu);
		return true;
	}

}
