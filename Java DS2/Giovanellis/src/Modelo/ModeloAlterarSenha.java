/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author Alex
 */
public class ModeloAlterarSenha {

    public ModeloAlterarSenha(int CodFuncionario, int CodPermissao, String Login, String Permissao, String Senha) {
        this.CodFuncionario = CodFuncionario;
        this.CodPermissao = CodPermissao;
        this.Login = Login;
        this.Permissao = Permissao;
        this.Senha = Senha;
    }
    private int CodFuncionario, CodPermissao;
    private String Login, Permissao, Senha;

    public ModeloAlterarSenha() {
        
    }

    /**
     * @return the CodFuncionario
     */
    public int getCodFuncionario() {
        return CodFuncionario;
    }

    /**
     * @param CodFuncionario the CodFuncionario to set
     */
    public void setCodFuncionario(int CodFuncionario) {
        this.CodFuncionario = CodFuncionario;
    }

    /**
     * @return the CodPermissao
     */
    public int getCodPermissao() {
        return CodPermissao;
    }

    /**
     * @param CodPermissao the CodPermissao to set
     */
    public void setCodPermissao(int CodPermissao) {
        this.CodPermissao = CodPermissao;
    }

    /**
     * @return the NomeFuncionario
     */
    public String getLogin() {
        return Login;
    }

    /**
     * @param NomeFuncionario the NomeFuncionario to set
     */
    public void setLogin(String Login) {
        this.Login = Login;
    }

    /**
     * @return the Permissao
     */
    public String getPermissao() {
        return Permissao;
    }

    /**
     * @param Permissao the Permissao to set
     */
    public void setPermissao(String Permissao) {
        this.Permissao = Permissao;
    }

    /**
     * @return the Senha
     */
    public String getSenha() {
        return Senha;
    }

    /**
     * @param Senha the Senha to set
     */
    public void setSenha(String Senha) {
        this.Senha = Senha;
    }
    
}
