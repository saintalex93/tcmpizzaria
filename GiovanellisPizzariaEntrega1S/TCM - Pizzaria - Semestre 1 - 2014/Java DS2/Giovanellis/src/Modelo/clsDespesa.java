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
public class clsDespesa {
    private String NomeDespesa;
    private String SituacaoDespesa;
    private int CodDespesa;
   
    
    

    public clsDespesa(String NomeDespesa, String SituacaoDespesa) {
        this.NomeDespesa = NomeDespesa;
        this.SituacaoDespesa = SituacaoDespesa;
        
    }

    public clsDespesa() {
    }

    /**
     * @return the NomeDespesa
     */
    public String getNomeDespesa() {
        return NomeDespesa;
    }

    /**
     * @param NomeDespesa the NomeDespesa to set
     */
    public void setNomeDespesa(String NomeDespesa) {
        this.NomeDespesa = NomeDespesa;
    }

    /**
     * @return the SituacaoDespesa
     */
    public String getSituacaoDespesa() {
        return SituacaoDespesa;
    }

    /**
     * @param SituacaoDespesa the SituacaoDespesa to set
     */
    public void setSituacaoDespesa(String SituacaoDespesa) {
        this.SituacaoDespesa = SituacaoDespesa;
    }

    /**
     * @return the CodDespesa
     */
    public int getCodDespesa() {
        return CodDespesa;
    }

    /**
     * @param CodDespesa the CodDespesa to set
     */
    public void setCodDespesa(int CodDespesa) {
        this.CodDespesa = CodDespesa;
    }
    
}
