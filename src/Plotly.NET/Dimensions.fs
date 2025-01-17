namespace Plotly.NET

open DynamicObj
open System

/// Dimensions type inherits from dynamic object
type Dimensions () =
    inherit DynamicObj ()

    /// Initialized Dimensions object
    static member init
        (
            ?Values: seq<#IConvertible>,
            ?Range: StyleParam.Range,
            ?Constraintrange: StyleParam.Range,
            ?Visible: bool,
            ?Label: #IConvertible,
            ?Tickvals: seq<#IConvertible>,
            ?TickText: seq<#IConvertible>,
            ?TickFormat: StyleParam.TickMode
        ) =
            Dimensions () 
            |> Dimensions.style
                (
                    ?Values          = Values    ,
                    ?Range           = Range     ,
                    ?Constraintrange = Constraintrange,
                    ?Visible         = Visible,
                    ?Label           = Label,
                    ?Tickvals        = Tickvals,
                    ?TickText        = TickText,
                    ?TickFormat      = TickFormat
                )


    // Applies the styles to Dimensions()
    static member style
        (
            ?Values: seq<#IConvertible>,
            ?Range: StyleParam.Range,
            ?Constraintrange: StyleParam.Range,
            ?Visible: bool,
            ?Label: #IConvertible,
            ?Tickvals: seq<#IConvertible>,
            ?TickText: seq<#IConvertible>,
            ?TickFormat: StyleParam.TickMode
        ) =
            (fun (dims:Dimensions) -> 
                Values           |> DynObj.setValueOpt   dims "values"
                Range            |> DynObj.setValueOptBy dims "range" StyleParam.Range.convert                
                Constraintrange  |> DynObj.setValueOptBy dims "constraintrange" StyleParam.Range.convert                 
                Visible          |> DynObj.setValueOpt   dims "Visible"
                Label            |> DynObj.setValueOpt   dims "label"
                Tickvals         |> DynObj.setValueOpt   dims "tickvals"
                TickText         |> DynObj.setValueOpt   dims "ticktext"   
                TickFormat       |> DynObj.setValueOpt   dims "tickformat"
                
                // out -> 
                dims
            )



               