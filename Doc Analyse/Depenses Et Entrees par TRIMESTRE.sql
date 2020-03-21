 ALTER VIEW Affichage_Finance_Depense_Trimestre AS
SELECT Designation,Departement,Montant,Annee,DateDepense,(SELECT Nom FROM Eglise) as Eglise,(SELECT Communaute FROM Eglise) Communaute,(SELECT Accronyme FROM Eglise) as Acro,(SELECT Logo FROM Eglise) as Logo, 
	(CASE WHEN DATEPART(QQ,DateDepense)=1 THEN '1er TRIMESTRE'
            WHEN DATEPART(QQ,DateDepense)=2 THEN '2eme TRIMESTRE'
            WHEN DATEPART(QQ,DateDepense)=3 THEN '3eme TRIMESTRE'
            WHEN DATEPART(QQ,DateDepense)=4 THEN '4eme TRIMESTRE'
                  END) AS Trimestre,Mois
 FROM Affichage_Finance_Depense
 GO
 ALTER VIEW Affichage_Finance_Entree_Trimestre AS
 SELECT Designation,Departement,Montant,Annee,DateOperation,(SELECT Nom FROM Eglise) as Eglise,(SELECT Communaute FROM Eglise) Communaute,(SELECT Accronyme FROM Eglise) as Acro,(SELECT Logo FROM Eglise) as Logo, 
	(CASE WHEN DATEPART(QQ,DateEntree)=1 THEN '1er TRIMESTRE'
            WHEN DATEPART(QQ,DateEntree)=2 THEN '2eme TRIMESTRE'
            WHEN DATEPART(QQ,DateEntree)=3 THEN '3eme TRIMESTRE'
            WHEN DATEPART(QQ,DateEntree)=4 THEN '4eme TRIMESTRE'
                  END) AS Trimestre,Mois
 FROM Affichage_Finance_Entree