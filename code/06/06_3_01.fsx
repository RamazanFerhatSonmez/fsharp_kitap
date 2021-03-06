(* 06_3_01.fsx*)

// -------- Basit veri tipinen değişkenler --------
let mutable sayı = 42
printfn "İlk değer, sayı = %d" sayı
// Çıktı : İlk değer, sayı = 42

sayı <- sayı + 1
printfn "Yeni değer, sayı = %d" sayı
// Çıktı : Yeni değer, sayı = 43


// -------- Temel veri tipinen değişkenler --------

// Değer grubu
let mutable grup = ("Ali",2)
printfn "İlk değer, grup  = %A" grup
// Çıktı : İlk değer, grup = ("Ali",2)


grup <- "Arda",1
printfn "Yeni değer, grup = %A" grup
// Çıktı : Yeni değer, grup = ("Arda",2)


// Opsiyon
let mutable opsiyon = Some 1
printfn "İlk değer, opsiyon  = %A" opsiyon
// Çıktı : İlk değer, opsiyon = Some 1


opsiyon <- Some 42
printfn "Yeni değer, opsiyon = %A" grup
// Çıktı : Yeni değer, opsiyon = Some 42


// Liste
let mutable liste = [1;2;3]
printfn "İlk değer, liste = %A" liste
// Çıktı : İlk değer, liste = [1; 2; 3]

liste <- [for i in 1..3 do yield 42]
printfn "Yeni değer, liste = %A" liste
// Çıktı : Yeni değer, liste = [42; 42; 42]

// Sekans
let mutable sekans = seq{for i in 1..3 do yield i}
printfn "İlk değer, sekans = %A" sekans
// Çıktı : İlk değer, sekans = seq [1; 2; 3]

sekans <- seq{for i in 1..3 do yield 42}
printfn "Yeni değer, sekans = %A" liste
// Çıktı : Yeni değer, sekans = [42; 42; 42]


// -------- Özel veri tipinen değişkenler --------
type Kişi = {
    AdSoyad :string
    mutable DoğumYılı: int option}

let kişi = {AdSoyad="Mahmut Tuncer";DoğumYılı=None}
printfn "İlk değer, kişi = %A" kişi
// Çıktı : İlk değer, kişi = {AdSoyad = "Mahmut Tuncer"; DoğumYılı = None;}

kişi.DoğumYılı <- Some 1961
printfn "Yeni değer, kişi = %A" kişi
// Çıktı : Yeni değer, kişi = {AdSoyad = "Mahmut Tuncer"; DoğumYılı = Some 1961;}




//let topla (x:byref<int>) (y:byref<int>)= 
let topla (x:int byref) (y:int byref)= 
    let toplam = x + y
    x <- 0
    y <- 0
    toplam

let mutable x = 6 // mutable ile değişken  
let mutable y = 7 // mutable ile değişken  
let toplam = topla &x &y // adres operatörü & kullanılmalı
printfn "Yeni değerler: x = %d, y = %d, toplam = %d " x y toplam
// Çıktı : Yeni değerler: x = 0, y = 0, toplam = 2



    