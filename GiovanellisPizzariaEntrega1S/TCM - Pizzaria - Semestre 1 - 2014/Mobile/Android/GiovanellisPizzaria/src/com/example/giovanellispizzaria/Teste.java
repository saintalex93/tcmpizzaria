package com.example.giovanellispizzaria;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.view.Menu;
import android.widget.Button;
import android.widget.RelativeLayout;
import android.widget.RelativeLayout.LayoutParams;
import android.widget.TextView;
import android.widget.Toast;

public class Teste extends Activity {

	TextView tv1;
	private TextView recent;
	private Button b1;
	protected LayoutParams lp;
	
	@Override
	public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        
        setContentView(R.layout.activity_teste);
        
        //Toast.makeText(getApplicationContext(), rr.toString(), Toast.LENGTH_LONG).show();
        
/*        b1 = new Button(this);
        b1.setId((int) System.currentTimeMillis());
        recent = b1;
        b1.setText("Click me");
  */      
        //rr.addView(b1);

//        setContentView(rr);
        
        
/*        for(int i = 0; i < 3; i++)
        {
        	tv1 = new TextView(getApplicationContext());
            tv1.setId((int)System.currentTimeMillis());
            tv1.setTextColor(Color.BLACK);
            lp = new RelativeLayout.LayoutParams(LayoutParams.WRAP_CONTENT,LayoutParams.WRAP_CONTENT);
            lp.addRule(RelativeLayout.BELOW, recent.getId());
            tv1.setText("Time: "+System.currentTimeMillis());
            //	rr.addView(tv1, lp);
            recent = tv1;
        }*/

/*        b1.setOnClickListener(new View.OnClickListener() 
        {
        	

            @Override
            public void onClick(View v) {
                tv1 = new TextView(getApplicationContext());
                tv1.setId((int)System.currentTimeMillis());
                tv1.setTextColor(Color.BLACK);
                lp = new RelativeLayout.LayoutParams(LayoutParams.WRAP_CONTENT,LayoutParams.WRAP_CONTENT);
                lp.addRule(RelativeLayout.BELOW, recent.getId());
                tv1.setText("Time: "+System.currentTimeMillis());
                rr.addView(tv1, lp);
                recent = tv1;
            }
        });
*/    }

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.teste, menu);
		return true;
	}

}
