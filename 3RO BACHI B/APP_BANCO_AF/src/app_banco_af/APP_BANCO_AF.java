/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package app_banco_af;

import java.util.Scanner;

/**
 *
 * @author UELD-USER-19
 */
public class APP_BANCO_AF {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
         Scanner scanner = new Scanner(System.in);
        
        System.out.print("Ingrese el tipo de tarjeta (1, 2, 3, u otro número): ");
        int tipoTarjeta = scanner.nextInt();
        
        System.out.print("Ingrese el límite de crédito actual: ");
        double limiteActual = scanner.nextDouble();
        
        double aumentoPorcentaje;
        
        switch (tipoTarjeta) {
            case 1:
                aumentoPorcentaje = 0.25;
                break;
            case 2:
                aumentoPorcentaje = 0.35;
                break;
            case 3:
                aumentoPorcentaje = 0.40;
                break;
            default:
                aumentoPorcentaje = 0.50;
                break;
        }
        
        double aumentoTotal = limiteActual * aumentoPorcentaje;
        double nuevoLimite = limiteActual + aumentoTotal;
        
        System.out.println("El nuevo límite de crédito es: " + nuevoLimite);
        
        scanner.close();
    }
    
}
