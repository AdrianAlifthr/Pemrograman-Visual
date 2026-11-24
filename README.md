# Pemrograman Visual

Repositori pembelajaran dan praktikum mata kuliah **Pemrograman Visual** menggunakan **Visual Basic .NET (VB.NET)** dan **Windows Forms** pada **Visual Studio**.

Proyek ini mencakup pembelajaran dari Pertemuan 1 sampai Pertemuan 8, mulai dari pengenalan Visual Studio, komponen visual, operator dan struktur kendali, pengulangan, modul, fungsi dan koleksi, koneksi database, validasi input, hingga DataGridView.

---

## Daftar Isi

- [Teknologi](#teknologi)
- [Struktur Repositori](#struktur-repositori)
- [Materi Pertemuan](#materi-pertemuan)
  - [Pertemuan 1](#pertemuan-1-pengenalan-pemrograman-visual)
  - [Pertemuan 2](#pertemuan-2-komponen-visual)
  - [Pertemuan 3](#pertemuan-3-operator-dan-struktur-kendali)
  - [Pertemuan 4](#pertemuan-4-perulangan)
  - [Pertemuan 5](#pertemuan-5-modul-fungsi-array-dan-koleksi)
  - [Pertemuan 6](#pertemuan-6-koneksi-database)
  - [Pertemuan 7](#pertemuan-7-validasi-input-dan-error-handling)
  - [Pertemuan 8](#pertemuan-8-datagridview-array-dan-koleksi-data)
- [Praktikum dan Latihan](#praktikum-dan-latihan)
- [Cara Menjalankan](#cara-menjalankan)
- [Penulis](#penulis)

---

## Teknologi

- Visual Basic .NET (`VB.NET`)
- Windows Forms
- Microsoft Visual Studio
- .NET 10.0 / Windows
- PostgreSQL melalui Npgsql untuk praktikum Pertemuan 6
- Git dan GitHub

## Struktur Repositori

| Folder | Materi |
|---|---|
| `pertemuan1/` | Pengenalan pemrograman visual dan Visual Studio |
| `pertemuan2_komponen_visual/` | Komponen dan properti visual Windows Forms |
| `Pertemuan3-Operator-Struktur_Kendali/` | Operator dan struktur kendali |
| `peremuan4 Pengulangan/` | Struktur perulangan |
| `pertemuan5_modul_fungsi_array_koleksi_data/` | Modul, fungsi, array, dan koleksi data |
| `Pertemuan 6/` | Koneksi database dan form mahasiswa |
| `pertemuan7_validasi_input/` | Validasi input dan penanganan exception |
| `pertemuan8_datagridview_array_koleksi_data/` | DataGridView, Array, List, dan DataTable |
| `Latihan 1/` | Latihan form dan navigasi Windows Forms |
| `Tugas 1 Adrian/` | Tugas Windows Forms |

## Materi Pertemuan

### Pertemuan 1: Pengenalan Pemrograman Visual

Materi dasar meliputi:

- Pengertian pemrograman visual
- Perbedaan pemrograman visual dan pemrograman konvensional
- Pengenalan Visual Studio
- Pengenalan Visual Basic .NET
- Pengenalan Windows Forms dan .NET
- Struktur dasar proyek Visual Studio
- Perbedaan file `Form.vb` dan `Form.Designer.vb`

Detail materi tersedia di folder [`pertemuan1`](./pertemuan1).

### Pertemuan 2: Komponen Visual

Materi meliputi penggunaan komponen visual Windows Forms, antara lain:

- `Label`
- `TextBox`
- `Button`
- `ComboBox`
- `RadioButton`
- `CheckBox`
- Pengaturan properti kontrol
- Penanganan event
- Implementasi form sederhana

Detail materi tersedia di folder [`pertemuan2_komponen_visual`](./pertemuan2_komponen_visual).

### Pertemuan 3: Operator dan Struktur Kendali

Materi meliputi:

- Operator aritmetika
- Operator pembanding
- Operator logika
- Percabangan `If...Then...Else`
- Percabangan `Select...Case`
- Pengambilan keputusan menggunakan data visual

Detail materi tersedia di folder [`Pertemuan3-Operator-Struktur_Kendali`](./Pertemuan3-Operator-Struktur_Kendali).

### Pertemuan 4: Perulangan

Materi meliputi penggunaan struktur pengulangan, seperti:

- `For...Next`
- `For Each...Next`
- `Do...Loop`
- `While...End While`
- Pengolahan kumpulan data berulang

Detail materi tersedia di folder [`peremuan4 Pengulangan`](./peremuan4%20Pengulangan).

### Pertemuan 5: Modul, Fungsi, Array, dan Koleksi

Materi meliputi:

- Pembuatan modul
- Pembuatan `Function` dan `Sub`
- Parameter dan nilai kembalian
- Array satu dimensi
- Array dua dimensi
- Koleksi `List(Of T)`
- Pengelompokan kode ke dalam modul

Detail materi tersedia di folder [`pertemuan5_modul_fungsi_array_koleksi_data`](./pertemuan5_modul_fungsi_array_koleksi_data).

### Pertemuan 6: Koneksi Database

Materi meliputi:

- Konfigurasi database melalui `appsettings.json`
- Koneksi aplikasi menggunakan Npgsql
- Modul database, query, dan function
- Form data mahasiswa
- Operasi pengambilan dan pengolahan data database
- Pemisahan kode database dari kode form

Detail materi tersedia di folder [`Pertemuan 6`](./Pertemuan%206).

### Pertemuan 7: Validasi Input dan Error Handling

Materi meliputi:

- Naming convention untuk komponen visual
- Jenis error:
  - Syntax error
  - Runtime error atau exception
  - Logic error
- `Try...Catch...Finally`
- `Integer.TryParse` dan konversi angka
- `Decimal.TryParse`
- `ErrorProvider`
- Validasi nama, NIM, jurusan, angkatan, dan IPK
- Ekspor data ke file CSV

Detail materi tersedia di folder [`pertemuan7_validasi_input`](./pertemuan7_validasi_input).

### Pertemuan 8: DataGridView, Array, dan Koleksi Data

Materi meliputi:

- Penggunaan `DataGridView`
- Pengisian data secara manual atau unbound
- Penggunaan Array dua dimensi
- Penggunaan `List(Of T)` dan class model
- Penggunaan `DataTable`
- Pengikatan data melalui `BindingSource`
- Format kolom dan pencarian data
- Perbedaan Array, List, dan DataTable

Detail materi tersedia di folder [`pertemuan8_datagridview_array_koleksi_data`](./pertemuan8_datagridview_array_koleksi_data).

## Praktikum dan Latihan

Repositori juga memuat beberapa latihan pendukung:

- **Latihan 1** — penggunaan form, navigasi, gambar aset, dan kontrol visual.
- **Tugas 1 Adrian** — tugas Windows Forms dengan form untuk staff dan manager.
- **Pertemuan 7** — form utama, form pendaftaran, dan pengujian konversi data.
- **Pertemuan 8** — contoh pengisian DataGridView dari Array, List, dan DataTable.

## Cara Menjalankan

1. Install [Visual Studio](https://visualstudio.microsoft.com/) dengan workload **.NET desktop development**.
2. Pastikan Windows Forms .NET 10.0 tersedia pada komputer.
3. Clone repositori:

```bash
git clone https://github.com/AdrianAlifthr/Pemrograman-Visual.git
```

4. Buka salah satu file `.sln` atau `.slnx` pada folder praktikum.
5. Pilih konfigurasi **Debug**.
6. Jalankan proyek menggunakan **Start** atau tekan `F5`.

Untuk proyek Pertemuan 6:

1. Siapkan PostgreSQL.
2. Sesuaikan konfigurasi koneksi pada `appsettings.json`.
3. Pastikan package Npgsql tersedia pada proyek.
4. Jalankan `Pertemuan 6.slnx`.

## Penulis

- **Nama:** Adrian Alif Athir
- **GitHub:** [AdrianAlifthr](https://github.com/AdrianAlifthr)
