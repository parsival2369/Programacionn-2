﻿using System;

public class Asignatura
{
    public interface IAsignatura
    {
		{
		double CalcularNotaFinal();
        double CalcularNotaFinal(int N1, int N2, int N3);
        string MensajeNotaFinal(double notaFinal);
        void Imprimir();
    }



}
}
