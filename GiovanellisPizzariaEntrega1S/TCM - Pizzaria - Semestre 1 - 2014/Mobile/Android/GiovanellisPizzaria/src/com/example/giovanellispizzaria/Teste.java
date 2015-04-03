package com.example.giovanellispizzaria;

import android.app.Activity;
import android.graphics.Color;
import android.os.Bundle;
import android.view.Menu;
import android.widget.LinearLayout;
import android.widget.TextView;

public class Teste extends Activity {

	TextView tv;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_teste);
		
		
		String[] textArray={"one","two","asdasasdf asdf dsdaa"};
		int length=textArray.length;
		LinearLayout layout = new LinearLayout(this);
		setContentView(layout);
		layout.setOrientation(LinearLayout.VERTICAL);        
		for(int i=0;i<length;i++)
		{
		    TextView tv = new TextView(getApplicationContext());
		    tv.setText(textArray[i]);
		    tv.setTextColor(Color.BLACK);
		    layout.addView(tv);
		}
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.teste, menu);
		return true;
	}

}
