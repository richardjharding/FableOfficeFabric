module Fable.Helpers.OfficeFabric

open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Import.React
open Fable.Core.JsInterop
open React.Props
open System

let styles = JsInterop.importAll<obj> "office-ui-fabric-react/dist/sass/fabric.scss"


type [<Pojo>] IIconProps=
    {iconName: string}

type [<Pojo>] IButtonProps =
    { text: string
      iconProps: IIconProps}

let DefaultButton = import<ComponentClass<IButtonProps>> "DefaultButton" "office-ui-fabric-react/lib/components/button"
let inline defaultButton b c = React.from DefaultButton b c