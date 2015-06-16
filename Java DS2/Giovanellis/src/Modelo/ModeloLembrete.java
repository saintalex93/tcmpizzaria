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
public class ModeloLembrete {
    
    
    private int CodLembrete;
    private int codFuncionario;
    private String Assunto;
    private String Mensagem;
    private String DataCriacao;
    private String DataAviso;
    private int Aviso;

    public ModeloLembrete(int CodLembrete, int codFuncionario, String Assunto, String Mensagem, String DataCriacao, String DataAviso, int Aviso) {
        this.CodLembrete = CodLembrete;
        this.codFuncionario = codFuncionario;
        this.Assunto = Assunto;
        this.Mensagem = Mensagem;
        this.DataCriacao = DataCriacao;
        this.DataAviso = DataAviso;
        this.Aviso = Aviso;
    }
    
    

    public ModeloLembrete() {
        
        
    }

    /**
     * @return the CodLembrete
     */
    public int getCodLembrete() {
        return CodLembrete;
    }

    /**
     * @param CodLembrete the CodLembrete to set
     */
    public void setCodLembrete(int CodLembrete) {
        this.CodLembrete = CodLembrete;
    }

    /**
     * @return the codFuncionario
     */
    public int getCodFuncionario() {
        return codFuncionario;
    }

    /**
     * @param codFuncionario the codFuncionario to set
     */
    public void setCodFuncionario(int codFuncionario) {
        this.codFuncionario = codFuncionario;
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
     * @return the DataAviso
     */
    public String getDataAviso() {
        return DataAviso;
    }

    /**
     * @param DataAviso the DataAviso to set
     */
    public void setDataAviso(String DataAviso) {
        this.DataAviso = DataAviso;
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
