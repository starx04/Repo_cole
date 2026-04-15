/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_mayor_de_2_numeros;

/**
 *
 * @author PC
 */
public class App_Mayor_De_2_Numeros {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        int num1,num2;
        num1=JoptionPane.showImputDialog("Ingrese su primer numero: ");
        num2=JoptionPane.showImputDialog("Ingrese su segundo numero: ");
        if (num1>num2)
            JoptionPane.showMessageDialog(null,"El numero mayor entree los 2 es "+num1);
            else if(num2>num1)
            JoptionPane.showMessageDialog(null,"El numero mayor entree los 2 es "+num2);
    }
    
}
