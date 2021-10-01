namespace App

open Feliz
open Feliz.Router
open Feliz.Plotly

type Components =

    /// <summary>
    /// A plotly graph
    /// Based on: https://stackoverflow.com/questions/42423167/custom-vertical-line-using-plotly-js
    /// </summary>
    [<ReactComponent>]
    static member PlotlyGraph() =
        let x = ["2000-01-01"; "2000-01-02"; "2000-01-03"; "2000-01-04"; "2000-01-05"; "2000-01-06"; "2000-01-07"; "2000-01-08"; "2000-01-09"; "2000-01-10"; "2000-01-11"; "2000-01-12"; "2000-01-13"; "2000-01-14"; "2000-01-15"; "2000-01-16"; "2000-01-17"; "2000-01-18"; "2000-01-19"; "2000-01-20"; "2000-01-21"; "2000-01-22"; "2000-01-23"; "2000-01-24"; "2000-01-25"; "2000-01-26"; "2000-01-27"; "2000-01-28"; "2000-01-29"; "2000-01-30"; "2000-01-31"]

        let y = [4.3; 8.2; 4.1; 5.6; -3.; -0.2; 0.3; 0.4; 4.1; 5.; 4.6; -0.2; -8.5; -9.1; -2.7; -2.7; -17.; -11.3; -5.5; -6.5; -16.9; -12.; -6.1; -6.6; -7.9; -10.8; -14.8; -11.; -4.4; -1.3; -1.1]
  
        Plotly.plot [
            plot.traces [
                traces.scatter [
                    scatter.x x
                    scatter.y y
                    scatter.mode.lines
                    scatter.name "2000"
                ]
            ]

            plot.layout [ 
                layout.xaxis [
                    xaxis.type'.date
                    xaxis.title "January Weather"
                ]
                layout.yaxis [
                    yaxis.title "Daily Mean Temperature"
                ] 
                layout.shapes [
                    shapes.shape [
                        shape.type'.line
                        shape.x0 "2000-01-11"
                        shape.y0 0
                        shape.x1 "2000-01-11"
                        shape.yref.paper
                        shape.y1 1
                        shape.line [
                            line.color "grey"
                            line.width 1.5
                            line.dash.dot
                        ]
                    ]
                    shapes.shape [
                        shape.type'.line
                        shape.x0 "2000-01-17"
                        shape.y0 0
                        shape.x1 "2000-01-17"
                        shape.y1 (List.min y)
                        shape.line [
                            line.color "grey"
                            line.width 1.5
                            line.dash.dot
                        ]
                    ]
                    shapes.shape [
                        shape.type'.line
                        shape.x0 "2000-01-02"
                        shape.y0 0
                        shape.x1 "2000-01-02"
                        shape.y1 (List.min y)
                        shape.line [
                            line.color "grey"
                            line.width 1.5
                            line.dash.dot
                        ]
                    ]
                ]
                layout.title "2000 Toronto January Weather" ]
        ]
    