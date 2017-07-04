module Fable.Helpers.OfficeFabric

open Fable.Core
open Fable.Import
open Fable.Import.JS
open Fable.Import.React
open Fable.Core.JsInterop
open React.Props
open System

let styles = JsInterop.importAll<obj> "office-ui-fabric-react/dist/sass/fabric.scss"


type IIconProps=
    | IconName of string

type IButtonProps =
    | Text of string
    | IconProps of IIconProps list



let DefaultButton: ComponentClass<obj> =
     import "DefaultButton" "office-ui-fabric-react/lib/components/button"
let inline defaultButton (props: IButtonProps list) c =
     React.from DefaultButton (keyValueList CaseRules.LowerFirst props) c