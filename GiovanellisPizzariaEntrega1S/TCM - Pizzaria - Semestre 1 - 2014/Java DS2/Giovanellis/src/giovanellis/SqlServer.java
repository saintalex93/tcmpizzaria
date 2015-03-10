/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package giovanellis;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author ETESP
 */
public class SqlServer {
    
    
    String driver="com.microsoft.sqlserver.jdbc.SQLServerDriver";
    // Sempre que for procurar o driver para o java começa com jdbc
    String caminho ="jdbc:sqlserver://localhoist\\MSSQLSERVER:1433;"+
    "DatabaseName=Clientes";
    private String usuario ="aluno";
    private String senha ="etesp";
    
    private Connection conn;
    
    //Método para conexão com o Banco
    public void conectar (){
        
        try {
            Class.forName(this.driver);
            this.setConn(DriverManager.getConnection(
                    this.caminho,
                    this.usuario,
                    this.senha));
            
            JOptionPane.showMessageDialog(null, "Conexão Ok");
        } catch (ClassNotFoundException ex)
        {
            JOptionPane.showMessageDialog(null, ex.getMessage());

            }
          catch (SQLException ex) {
                Logger.getLogger(SqlServer.class.getName()).log(Level.SEVERE, null, ex.getMessage());
            }
       
        
       
        
        }
     public void desconectar (){
        try {
            this.getConn().close();
        } catch (SQLException ex) {
            Logger.getLogger(SqlServer.class.getName()).log(Level.SEVERE, null, ex);
        }
     }
     
    

    /**
     * @return the conn
     */
    public Connection getConn() {
        return conn;
    }

    /**
     * @param conn the conn to set
     */
    public void setConn(Connection conn) {
        this.conn = conn;
    }
}
