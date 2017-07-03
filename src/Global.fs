module Global

type Page =
  | Home
  | Counter
  | About
  | Fabric

let toHash page =
  match page with
  | About -> "#about"
  | Counter -> "#counter"
  | Home -> "#home"  
  | Fabric -> "#fabric"
