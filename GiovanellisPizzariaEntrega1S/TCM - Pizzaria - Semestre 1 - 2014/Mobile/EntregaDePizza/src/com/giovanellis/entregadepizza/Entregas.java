package com.giovanellis.entregadepizza;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

import android.app.Activity;
import android.os.Bundle;
import android.view.Menu;
import android.widget.TextView;

import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.Toast;
import android.widget.TextView;
import java.sql.*;

public class Entregas extends Activity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_entregas);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.entregas, menu);
        return true;
    }
    
    public void connectTodatabase()
    {
        TextView txtView = (TextView)findViewById(R.id.txtLogin.);
        String url = "jdbc:jtds:sqlserver://XXX.XXX.X.XXX:1433;DatabaseName=VautomateuShoppi";
        String driver = "net.sourceforge.jtds.jdbc.Driver";
        String userName = "VShopping_User";
        String password = "VShopping_Pass";   
        // Declare the JDBC objects.
        Connection con = null;
        Statement stmt = null;
        ResultSet rs = null;
    try
    {

        // Establish the connection.
        Class.forName(driver);
        con = DriverManager.getConnection(url, userName, password);
            // Create and execute an SQL statement that returns some data.
            String SQL = "select * from Funcionario";
            stmt = con.createStatement();
            rs = stmt.executeQuery(SQL);

            // Iterate through the data in the result set and display it.
            while (rs.next()) {
                txtView.setText(rs.getString(2));
            }
    }
    catch(Exception ex)
    {
        txtView.setText(ex.getMessage().toString());
    }
    
    
}
