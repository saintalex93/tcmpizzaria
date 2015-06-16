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
public class ModeloMensagens {

    public ModeloMensagens(int CodMensagem, int CodRemetente, int CodDestinatario, String Assunto, String Mensagem, String DataCriacao, int Aviso) {
        this.CodMensagem = CodMensagem;
        this.CodRemetente = CodRemetente;
        this.CodDestinatario = CodDestinatario;
        this.Assunto = Assunto;
        this.Mensagem = Mensagem;
        this.DataCriacao = DataCriacao;
        this.Aviso = Aviso;
    }
    
private int CodMensagem ;
private int CodRemetente; 
private int CodDestinatario; 
private String Assunto; 
private String Mensagem;
private String DataCriacao;
private int Aviso;
    

    public ModeloMensagens() {
    }

    /**
     * @return the CodMensagem
     */
    public int getCodMensagem() {
        return CodMensagem;
    }

    /**
     * @param CodMensagem the CodMensagem to set
     */
    public void setCodMensagem(int CodMensagem) {
        this.CodMensagem = CodMensagem;
    }

    /**
     * @return the CodRemetente
     */
    public int getCodRemetente() {
        return CodRemetente;
    }

    /**
     * @param CodRemetente the CodRemetente to set
     */
    public void setCodRemetente(int CodRemetente) {
        this.CodRemetente = CodRemetente;
    }

    /**
     * @return the CodDestinatario
     */
    public int getCodDestinatario() {
        return CodDestinatario;
    }

    /**
     * @param CodDestinatario the CodDestinatario to set
     */
    public void setCodDestinatario(int CodDestinatario) {
        this.CodDestinatario = CodDestinatario;
    }

    /**
     * @return the Assunto
     */
    public String getAssunto() {
        return Assunto;
    }

    /**
     * @param Assunto the Assunto to set
     */
    public void setAssunto(String Assunto) {
        this.Assunto = Assunto;
    }

    /**
     * @return the Mensagem
     */
    public String getMensagem() {
        return Mensagem;
    }

    /**
     * @param Mensagem the Mensagem to set
     */
    public void setMensagem(String Mensagem) {
        this.Mensagem = Mensagem;
    }

    /**
     * @return the DataCriacao
     */
    public String getDataCriacao() {
        return DataCriacao;
    }

    /**
     * @param DataCriacao the DataCriacao to set
     */
    public void setDataCriacao(String DataCriacao) {
        this.DataCriacao = DataCriacao;
    }

    /**
     * @return the Aviso
     */
    public int getAviso() {
        return Aviso;
    }

    /**
     * @param Aviso the Aviso to set
     */
    public void setAviso(int Aviso) {
        this.Aviso = Aviso;
    }
    
}
