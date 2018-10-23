﻿Public Class EtapaRecorrida

    Private _Etapa As EtapaElaboracion
    Public Property Etapa() As EtapaElaboracion
        Get
            Return _Etapa
        End Get
        Set(ByVal value As EtapaElaboracion)
            _Etapa = value
        End Set
    End Property


    Private _Observacion As String
    Public Property Observacion() As String
        Get
            Return _Observacion
        End Get
        Set(ByVal value As String)
            _Observacion = value
        End Set
    End Property


    Private _Alarmas As List(Of Alarma)
    Public Property Alarmas() As List(Of Alarma)
        Get
            Return _Alarmas
        End Get
        Set(ByVal value As List(Of Alarma))
            _Alarmas = value
        End Set
    End Property


    Private _FechaInicio As Date
    Public Property FechaInicio() As Date
        Get
            Return _FechaInicio
        End Get
        Set(ByVal value As Date)
            _FechaInicio = value
        End Set
    End Property


    Private _FechaFin As Date
    Public Property FechaFin() As Date
        Get
            Return _FechaFin
        End Get
        Set(ByVal value As Date)
            _FechaFin = value
        End Set
    End Property



End Class
