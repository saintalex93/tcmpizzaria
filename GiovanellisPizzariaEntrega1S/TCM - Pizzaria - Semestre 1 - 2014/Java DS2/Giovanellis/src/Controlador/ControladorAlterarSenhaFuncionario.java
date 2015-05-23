/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;
import Modelo.ModeloAlterarSenha;
import giovanellis.SqlServer;
import java.sql.PreparedStatement;
import javax.swing.JOptionPane;
/**
 *
 * @author Alex
 */
public class ControladorAlterarSenhaFuncionario {
    SqlServer conn;
    
    public boolean AlterarPermissao(ModeloAlterarSenha objFunc) throws Exception {
        SqlServer conn = new SqlServer();
        
        String sql = "Update Funcionario set Login_funcionario = ?, Senha_Funcionario = ?, Cod_Permissao = ? where Cod_Funcionario = ?";
        PreparedStatement ps = conn.getConexao().prepareStatement(sql);
        ps.setString(1, objFunc.getLogin());
        ps.setString(2, objFunc.getSenha());
        ps.setInt(3, objFunc.getCodPermissao());
        ps.setInt(4, objFunc.getCodFuncionario());
        if(ps.executeUpdate() >0){
        return true;
        }        
        else{
        return false;
        }
    }
    

    public ControladorAlterarSenhaFuncionario() throws Exception {
        this.conn = new SqlServer();
    }
    
    
    
    
    
}
