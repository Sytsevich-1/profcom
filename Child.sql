USE [E:\MAKS\ДОКУМЕНТЫ\УНИВЕРСИТЕТ\2 КУРС\2 СЕМЕСТР\БД\ПРОФСОЮЗНАЯ БАЗА\PROFCOM_DB.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Person]    Script Date: 13.05.2022 23:40:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Person]
AS
	SET NOCOUNT ON;
SELECT Члены_профсоюза.Код_ЧП, Члены_профсоюза.Фамилия, Члены_профсоюза.Имя, Члены_профсоюза.Отчество, Дети.Фамилия AS Expr1, Дети.Имя AS Expr2, Дети.Отчество AS Expr3, Дети.Дата_рождения, Гендер.Пол
FROM Гендер INNER JOIN Дети ON Гендер.Код_пола = Дети.Код_пола INNER JOIN Члены_профсоюза ON Гендер.Код_пола = Члены_профсоюза.Код_пола INNER JOIN
                         Дети_родители ON Дети.Код_дети = Дети_родители.Код_дети AND Члены_профсоюза.Код_ЧП = Дети_родители.Код_ЧП