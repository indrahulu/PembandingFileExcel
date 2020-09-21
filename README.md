# PembandingFileExcel

Aplikasi sederhana untuk membandingkan 2 file Excel.

1. Pertama, pilih file Excel **lama**, kemudian file Excel **baru**.
2. Masukkan **nama Worksheet**. Kedua file Excel tadi harus memiliki Worksheet dengan nama dimaksud.
3. Masukkan range **Baris** dan **Kolom** yang akan diperiksa.
4. Aplikasi akan **membaca satu per satu Cell** yang masuk dalam range tadi. Bila ada Cell yang isinya tidak sama, maka Cell pada file Excel baru akan diformat dengan **warna background merah**.
5. Setelah selesai, **file Excel baru akan disimpan** sedangkan **file Excel lama tidak disimpan**.

Dibuat dengan Visual Studio Community 2019, WinForm dengan .Net Framework 4.7.2. 

File yang sudah di-compile bisa ambil di foler *bin/Debug* atau *bin/Release*