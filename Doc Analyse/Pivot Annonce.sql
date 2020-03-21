SELECT * FROM Affichage_Details_Communique
-----------------------------------PIVOT STATIC--------------------------------------------------------------------
CREATE VIEW Pivot_Annonce AS
SELECT Id,DatePublication,
[Vie de l'église] AS "VIE DE L'EGLISE",[Mamans] AS "MAMANS",[Papas] AS "PAPAS",[Jeunesse] AS "JEUNESSE",[Ecodim] AS "ECODIM",[Autres] AS "AUTRES"
FROM Affichage_Details_Communique
PIVOT (MAX(DetailsCommunique) FOR Departement
IN ([Vie de l'église],[Mamans],[Papas],[Jeunesse],[Ecodim],[Autres])) AS PVT
-----------------------------------PIVOT DYNAMIC-------------------------------------------------------------------
IF OBJECT_ID('tempdb..##TBL_TEMP') IS NOT NULL
DROP TABLE ##TBL_TEMP

DECLARE @SQLQUERY AS NVARCHAR(MAX)

DECLARE @PivotColumns NVARCHAR(MAX)


SELECT @PivotColumns = COALESCE(@PivotColumns + ',','') + QUOTENAME(Departement)
FROM [dbo].[Affichage_Details_Communique]

SELECT @PivotColumns

SET @SQLQUERY = N'SELECT Id,DatePublication,'+@PivotColumns+'
INTO ##TBL_TEMP
FROM [dbo].[Affichage_Details_Communique]
PIVOT(MAX(DetailsCommunique)
		FOR Departement IN ('+@PivotColumns+')) AS PVT'

--SELECT @SQLQUERY

EXEC sp_executesql @SQLQUERY

SELECT * FROM ##TBL_TEMP