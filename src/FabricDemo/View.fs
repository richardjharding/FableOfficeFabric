module FabricDemo.View

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Helpers.OfficeFabric

let root =
  div
    [ ClassName "content" ]
    [ h1
        [ ]
        [ str "Fabric Demo" ]
      p
        [ ]
        [ str "This pages exists to test the fabric ui bindings." ]
      defaultButton [IButtonProps.Text "Foo"
                     IconProps [IconName "Add"]
                     ] []  
         ]