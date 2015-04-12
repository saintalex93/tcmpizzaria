package com.example.giovanellispizzaria;

import java.io.BufferedInputStream;
import java.io.InputStream;
import java.net.URL;
import java.net.URLConnection;
import java.util.ArrayList;

import org.apache.http.client.HttpClient;
import org.apache.http.impl.client.DefaultHttpClient;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.StrictMode;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.RelativeLayout;
import android.widget.Toast;
import android.widget.RelativeLayout.LayoutParams;
import android.widget.TextView;

public class Login extends Activity {

	public static String nomeFuncionario = "";
	public static int codFuncionario = 0;

	TextView login;
	TextView senha;

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_login);

		StrictMode.ThreadPolicy policy = new StrictMode.ThreadPolicy.Builder()
				.permitAll().build();
		StrictMode.setThreadPolicy(policy);

		Button logar = (Button) findViewById(R.id.btnLogin);

		login = (TextView) findViewById(R.id.txtLogin);
		senha = (TextView) findViewById(R.id.txtSenha);

		logar.setOnClickListener(new OnClickListener() {
			public void onClick(View v) {

				if (login.getText().length() == 0) {
					Toast.makeText(
							getBaseContext(),
							"O LOGIN fornecido não é válido.\nPor favor, certifique-se de que ele está correto e tente de novo.",
							Toast.LENGTH_LONG).show();
					return;
				}

				if (senha.getText().length() == 0) {
					Toast.makeText(
							getBaseContext(),
							"A SENHA fornecida não é válido.\nPor favor, certifique-se de que ela está correta e tente de novo.",
							Toast.LENGTH_LONG).show();
					return;
				}

				String texto = "", aux = "";
				try {
					// ATENÇÃO A REDE DEVE ESTAR FUNCIONANDO COM O ENDEREÇO IP
					// OK

					// IP do curso
					// URL url = new
					// URL("http://10.67.74.32/default_consulta.aspx");

					// IP de casa

					URL url = new URL(
							"http://192.168.1.14/Giovanellis/consulta_login_id.aspx");

					URLConnection conexao = url.openConnection();

					Log.i("Input sozinho", conexao.getInputStream().toString());

					InputStream inputStream = conexao.getInputStream();

					BufferedInputStream bufferedInput = new BufferedInputStream(
							inputStream);
					int current = 0;

					while ((current = bufferedInput.read()) != -1) {
						texto = texto + ((char) (byte) current + "");
					}

					inputStream.close();

					// INÍCIO DA SEPARAÇÃO DOS
					// REGISTROS############################

					int tamanho = texto.length();
					boolean achou = false;

					for (int i = 0; i < tamanho; i++) {
						if (texto.charAt(i) == '#') {
							achou = true;
							i++;
						}

						if (texto.charAt(i) == '^')
							achou = false;

						if (achou) {
							if (texto.charAt(i) != ';'
									&& texto.charAt(i) != ',')
								aux = aux + texto.charAt(i);
							else if (texto.charAt(i) == ',') {
								codFuncionario = Integer.parseInt(aux);
								aux = "";
							} else if (texto.charAt(i) == ';') {
								nomeFuncionario = aux;
								aux = "";
							}
						}
					}

					// FIM DA SEPARAÇÃO DOS
					// REGISTROS##################################

				} catch (Exception e) {
					Log.d("asdf", "Message: " + e.getMessage());
					Log.d("asdf",
							"Localized message: " + e.getLocalizedMessage());
					Log.d("InputStream", "Message: " + e.getMessage()
							+ " - Resto dos erros:", e);
				}

				// HttpClient webClient = new DefaultHttpClient();

				if (nomeFuncionario.length() == 0)
					Toast.makeText(
							getApplicationContext(),
							"Não há nenhum usuário com o login e senha fornecidos.\nPor favor,  certifique-se de que estão corretos e tente de novo.",
							Toast.LENGTH_LONG).show();
				else 
				{
					Intent i = new Intent(getApplicationContext(), Home.class);
					startActivity(i);
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

}
