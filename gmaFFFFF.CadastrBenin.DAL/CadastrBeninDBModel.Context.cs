﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gmaFFFFF.CadastrBenin.DAL
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;
	using System.Data.Entity.Core.Objects;
	using System.Linq;
	
	public partial class CadastrBeninDB : DbContext
	{
		public CadastrBeninDB()
			: base("name=CadastrBeninDB")
		{
		}
	
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			throw new UnintentionalCodeFirstException();
		}
	
		public virtual DbSet<CadastraleDivision> CadastraleDivisions { get; set; }
		public virtual DbSet<CertificationDocument> CertificationDocuments { get; set; }
		public virtual DbSet<CertificationDocumentType> CertificationDocumentTypes { get; set; }
		public virtual DbSet<Impot> Impots { get; set; }
		public virtual DbSet<JuridiqueObjet> JuridiqueObjets { get; set; }
		public virtual DbSet<SinistreeRegion> SinistreeRegions { get; set; }
		public virtual DbSet<SinistreeType> SinistreeTypes { get; set; }
		public virtual DbSet<Utilisation> Utilisations { get; set; }
		public virtual DbSet<UtilisationType> UtilisationTypes { get; set; }
		public virtual DbSet<JuridiqueType> JuridiqueTypes { get; set; }
		public virtual DbSet<ProprietaireAncien> ProprietaireAnciens { get; set; }
		public virtual DbSet<ProprietairePresume> ProprietairePresumes { get; set; }
		public virtual DbSet<TransactionDocument> TransactionDocuments { get; set; }
		public virtual DbSet<TransactionDocumentType> TransactionDocumentTypes { get; set; }
		public virtual DbSet<TransactionObjet> TransactionObjets { get; set; }
		public virtual DbSet<Transaction> Transactions { get; set; }
		public virtual DbSet<TransactionType> TransactionTypes { get; set; }
		public virtual DbSet<Etat> Etats { get; set; }
		public virtual DbSet<SujetDocument> SujetDocuments { get; set; }
		public virtual DbSet<SujetDocumentType> SujetDocumentTypes { get; set; }
		public virtual DbSet<Sujet> Sujets { get; set; }
		public virtual DbSet<CadastraleDepartements_v> CadastraleDepartements_v { get; set; }
		public virtual DbSet<CadastraleSecteurs_v> CadastraleSecteurs_v { get; set; }
		public virtual DbSet<CadastraleZones_v> CadastraleZones_v { get; set; }
		public virtual DbSet<Immeubles_Parcelles_v> Immeubles_Parcelles_v { get; set; }
		public virtual DbSet<Immeubles_v> Immeubles_v { get; set; }
		public virtual DbSet<Parcelles_v> Parcelles_v { get; set; }
		public virtual DbSet<Sinestree_Parcelles_v> Sinestree_Parcelles_v { get; set; }
		public virtual DbSet<JuridiqueSituations_v> JuridiqueSituations_v { get; set; }
		public virtual DbSet<Parcel_ImmeubleIntersect> Parcel_ImmeubleIntersect { get; set; }
	
		[DbFunction("CadastrBeninDB", "ParseCadastralNumber")]
		public virtual IQueryable<ParseCadastralNumber_Result> ParseCadastralNumber(string cadNumber)
		{
			var cadNumberParameter = cadNumber != null ?
				new ObjectParameter("cadNumber", cadNumber) :
				new ObjectParameter("cadNumber", typeof(string));
	
			return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ParseCadastralNumber_Result>("[CadastrBeninDB].[ParseCadastralNumber](@cadNumber)", cadNumberParameter);
		}
	}
}