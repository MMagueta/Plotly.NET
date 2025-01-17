﻿namespace Plotly.NET

open DynamicObj
open System

/// <summary></summary>
type MapboxLayer() = 

    inherit DynamicObj ()

    /// <summary>Initialize a MapboxLayer object</summary>

    static member init
        (   
            ?Visible: bool,
            ?SourceType: StyleParam.MapboxLayerSourceType,
            ?Source: #IConvertible,
            ?SourceLayer: string,
            ?SourceAttribution: string,
            ?Type: StyleParam.MapboxLayerType,
            ?Coordinates:seq<#IConvertible*#IConvertible>,
            ?Below: string,
            ?Color: string,
            ?Opacity: float,
            ?MinZoom:float,
            ?MaxZoom:float,
            ?CircleRadius: float,
            ?Line:Line,
            ?FillOutlineColor:string,
            ?Symbol:MapboxLayerSymbol,
            ?Name: string
        ) =
            MapboxLayer()
            |> MapboxLayer.style
                (
                    ?Visible            = Visible          ,
                    ?SourceType         = SourceType       ,
                    ?Source             = Source           ,
                    ?SourceLayer        = SourceLayer      ,
                    ?SourceAttribution  = SourceAttribution,
                    ?Type               = Type             ,
                    ?Coordinates        = Coordinates      ,
                    ?Below              = Below            ,
                    ?Color              = Color            ,
                    ?Opacity            = Opacity          ,
                    ?MinZoom            = MinZoom          ,
                    ?MaxZoom            = MaxZoom          ,
                    ?CircleRadius       = CircleRadius     ,
                    ?Line               = Line             ,
                    ?FillOutlineColor   = FillOutlineColor ,
                    ?Symbol             = Symbol           ,
                    ?Name               = Name             
                )

    /// <summary>Create a function that applies the given style parameters to a MapboxLayer object.</summary>

    static member style
        (   
            ?Visible: bool,
            ?SourceType: StyleParam.MapboxLayerSourceType,
            ?Source: #IConvertible,
            ?SourceLayer: string,
            ?SourceAttribution: string,
            ?Type: StyleParam.MapboxLayerType,
            ?Coordinates:seq<#IConvertible*#IConvertible>,
            ?Below: string,
            ?Color: string,
            ?Opacity: float,
            ?MinZoom:float,
            ?MaxZoom:float,
            ?CircleRadius: float,
            ?Line:Line,
            ?FillOutlineColor:string,
            ?Symbol:MapboxLayerSymbol,
            ?Name: string

        ) =
            (fun (mapBoxLayer:MapboxLayer) -> 

                Visible          |> DynObj.setValueOpt mapBoxLayer "visible"
                SourceType       |> DynObj.setValueOptBy mapBoxLayer "sourcetype" StyleParam.MapboxLayerSourceType.convert
                Source           |> DynObj.setValueOpt mapBoxLayer "source"
                SourceLayer      |> DynObj.setValueOpt mapBoxLayer "sourcelayer"
                SourceAttribution|> DynObj.setValueOpt mapBoxLayer "sourceattribution"
                Type             |> DynObj.setValueOptBy mapBoxLayer "type" StyleParam.MapboxLayerType.convert
                Coordinates      |> DynObj.setValueOpt mapBoxLayer "coordinates"
                Below            |> DynObj.setValueOpt mapBoxLayer "below"
                Color            |> DynObj.setValueOpt mapBoxLayer "color"
                Opacity          |> DynObj.setValueOpt mapBoxLayer "opacity"
                MinZoom          |> DynObj.setValueOpt mapBoxLayer "minzoom"
                MaxZoom          |> DynObj.setValueOpt mapBoxLayer "maxzoom"

                CircleRadius     
                |> Option.map(fun r ->
                    let circle = DynamicObj()
                    circle?radius <- r
                    circle
                )
                |> DynObj.setValueOpt mapBoxLayer "circle"

                Line             |> DynObj.setValueOpt mapBoxLayer "line"

                FillOutlineColor
                |> Option.map(fun c ->
                    let fill = DynamicObj()
                    fill?outlinecolor <- c
                    fill
                )
                |> DynObj.setValueOpt mapBoxLayer "fill"

                Symbol           |> DynObj.setValueOpt mapBoxLayer "symbol"
                Name             |> DynObj.setValueOpt mapBoxLayer "name"
                                                       
                mapBoxLayer
            ) 
