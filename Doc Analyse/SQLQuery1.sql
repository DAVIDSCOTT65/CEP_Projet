CREATE TABLE #Sales(Empname CHAR(2),ProductSell INT,SellingDate DATE);


INSERT INTO #Sales 
  VALUES('A',7,'2017-11-01'),
        ('A',5,'2016-12-14'),
        ('C',5,'2017-02-11'),
        ('A',5,'2017-05-11'),
        ('B',10,'2016-11-04'),
        ('B',3,'2017-09-05'),
        ('D',1,'2017-11-05'),
         ('A',4,'2017-11-05');

		SELECT Empname,SUM(productsell) AS productsell,YEAR(SellingDate) AS SaleYear,
       (CASE WHEN DATEPART(QQ,SellingDate)=1 THEN '1st QUARTER'
            WHEN DATEPART(QQ,SellingDate)=2 THEN '2nd QUARTER'
            WHEN DATEPART(QQ,SellingDate)=3 THEN '3rd QUARTER'
            WHEN DATEPART(QQ,SellingDate)=4 THEN '4th QUARTER'
                  END) AS Sale_QUARTER,
       MAX(DateName(MOnth,SellingDate)) AS Sale_MONTH
  FROM #Sales
     GROUP BY YEAR(SellingDate), DATEPART(QQ,SellingDate),
               DATEPART(MONTH,SellingDate), Empname 
      ORDER BY YEAR(SellingDate),DATEPART(QQ,SellingDate),DATEPART(MONTH,SellingDate); 