using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.EntityFrameworkCore;

[Table("Prodotti")] 
public class Prodotto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; } = default!;

    [Column(TypeName = "decimal(18,2)")]
    public decimal Prezzo { get; set; }
}

public class ProdottoContext : DbContext
{
    public DbSet<Prodotto> Prodotti { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        string connectionString = "Server=localhost;Database=Prodotti_DB;User=root;Password=mysql123;";
        
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}

class Program
{
    static void Main()
    {
        using var db = new ProdottoContext();

        Console.WriteLine("Creazione db");
        
        db.Database.EnsureCreated();
        Console.WriteLine("1. Database verificato/creato con successo.");

        var nuovoProdotto = new Prodotto { Nome = "Computer", Prezzo = 125.00m };
        db.Prodotti.Add(nuovoProdotto);
        db.SaveChanges();
        Console.WriteLine($"2. Prodotto '{nuovoProdotto.Nome}' inserito.");

        Console.WriteLine("\n--- Lista Prodotti nel Database ---");
        var lista = db.Prodotti.ToList();
        
        foreach (var p in lista)
        {
            Console.WriteLine($"ID: {p.Id} | Nome: {p.Nome} | Prezzo: {p.Prezzo}€");
        }

        Console.WriteLine("\nOperazioni completate");
    }
}