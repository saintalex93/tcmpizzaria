/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

/**
 *
 * @author ETESP
 */
public class Contador {
       int contador = 10;
    
    public void escreva()
    {
        System.out.println(contador);
       
    }
 
    private javax.swing.Timer timer = new javax.swing.Timer(60*1000,new java.awt.event.ActionListener() {
        public void actionPerformed(java.awt.event.ActionEvent e)
        {
            escreva();
            contador--;
            if(contador == 0)
            {
               
              
            }
        }
        
    });
}
