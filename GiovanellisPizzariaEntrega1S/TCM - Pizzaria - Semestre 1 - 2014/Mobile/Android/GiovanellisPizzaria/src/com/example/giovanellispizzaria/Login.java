package com.example.giovanellispizzaria;

import java.io.BufferedInputStream;
import java.io.InputStream;
import java.net.URL;
import java.net.URLConnection;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.util.Log;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;
import android.widget.Toast;

public class Login extends Activity {

	public static String nomeFuncionario = "";

	// IP do curso	
	//public static String ip = "10.67.74.40";

	// IP de casa
	public static String ip = "192.168.1.8";

	public static int codFuncionario = 0;

	TextView lbLogin;
	TextView tvLogin;
	TextView tvSenha;
	
	ImageView logo;

	int usuario = 0;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_login);

		StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder().permitAll().build();
		StrictMode.setThreadPolicy(policy);

		Button logar = (Button) findViewById(R.id.btnLogin);

		lbLogin = (TextView) findViewById(R.id.s);
		tvLogin = (TextView) findViewById(R.id.txtLogin);
		tvSenha = (TextView) findViewById(R.id.txtSenha);
		
		logo = (ImageView) findViewById(R.drawable.marca);
		
		

		lbLogin.setOnClickListener
		(
			new View.OnClickListener()
			{
				public void onClick(View v)
				{
					switch(usuario)
					{
					case 0:
						tvLogin.setText("Maria");
						break;
						
					case 1:
						tvLogin.setText("Carlos");
						break;
						
					case 2:
						tvLogin.setText("Admin");
						break;

					case 3:
						tvLogin.setText("Alex");
						break;
					}
					
					if(usuario < 3)
						usuario++;
					else
						usuario = 0;
					
					tvSenha.setText("123");
				}
			}
		);
		
		logar.setOnClickListener(new OnClickListener() {
			public void onClick(View v) {

				if (tvLogin.getText().length() == 0) 
				{
					Toast.makeText(
							getBaseContext(),
							"O LOGIN fornecido não é válido.\n\nPor favor, certifique-se de que ele está correto e tente de novo.",
							Toast.LENGTH_LONG).show();
				
					return;
				}

				if (tvSenha.getText().length() == 0) 
				{
					Toast.makeText(
							getBaseContext(),
							"A SENHA fornecida não é válido.\n\nPor favor, certifique-se de que ela está correta e tente de novo.",
							Toast.LENGTH_LONG).show();
					
					return;
				}

				String texto = "", aux = "";
				try
				{
					// ATENÇÃO A REDE DEVE ESTAR FUNCIONANDO COM O ENDEREÇO IP
					// OK

					URL url = new URL("http://"+ ip +"/Giovanellis/consulta_login.aspx?Login_Funcionario="+tvLogin.getText()+"&Senha_Funcionario="+tvSenha.getText());

					URLConnection conexao = url.openConnection();

					InputStream inputStream = conexao.getInputStream();

					BufferedInputStream bufferedInput = new BufferedInputStream(inputStream);
					
					int current = 0;

					while ((current = bufferedInput.read()) != -1) 
						texto += ((char) (byte) current + "");

					inputStream.close();

					// INÍCIO DA SEPARAÇÃO DOS
					// REGISTROS############################

					int tamanho = texto.length();
					boolean achou = false;

					for (int i = 0; i < tamanho; i++) 
					{
						if (texto.charAt(i) == '#') 
						{
							achou = true;
							i++;
						}

						if (texto.charAt(i) == '^')
							achou = false;

						if (achou) 
						{
							if (texto.charAt(i) != ';'&& texto.charAt(i) != ',')
								aux += texto.charAt(i);
							
							else if (texto.charAt(i) == ',') 
							{
								codFuncionario = Integer.parseInt(aux);
								aux = "";
							} 
							else if (texto.charAt(i) == ';') 
							{
								nomeFuncionario = aux;
								aux = "";
							}
						}
					}

					// FIM DA SEPARAÇÃO DOS
					// REGISTROS##################################

				}
				catch (Exception e) 
				{
					Log.d("Login", "Message: " + e.getMessage());
				}

				if (nomeFuncionario.length() == 0)
					Toast.makeText(
							getApplicationContext(),
							"Não há nenhum usuário com o login e senha fornecidos.\n\nPor favor,  certifique-se de que estão corretos e tente de novo.",
							Toast.LENGTH_LONG).show();
				else 
				{
					try
					{
						Intent i = new Intent(getApplicationContext(), Home.class);
						startActivity(i);
					}
					catch (Exception e)
					{
						Log.d("Login - Intent", e.getMessage());
					}
					
					
				}

			}
		});
	}

	@Override
	public boolean onCreateOptionsMenu(Menu menu) {
		// Inflate the menu; this adds items to the action bar if it is present.
		getMenuInflater().inflate(R.menu.login, menu);
		return true;
	}
	
	@Override
	  public boolean onOptionsItemSelected(MenuItem item) {
		
//		Intent i = new Intent(getApplicationContext(), Settings.class);
	//	startActivity(i);

	    return true;
	  } 


}
