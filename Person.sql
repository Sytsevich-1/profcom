USE [E:\MAKS\ДОКУМЕНТЫ\УНИВЕРСИТЕТ\2 КУРС\2 СЕМЕСТР\БД\ПРОФСОЮЗНАЯ БАЗА\PROFCOM_DB.MDF]
GO
/****** Object:  StoredProcedure [dbo].[NewSelectCommand]    Script Date: 13.05.2022 21:50:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[NewSelectCommand]
AS
	SET NOCOUNT ON;
SELECT        Члены_профсоюза.Код_ЧП, Члены_профсоюза.Фамилия, Члены_профсоюза.Имя, Члены_профсоюза.Отчество, Члены_профсоюза.Дата_рождения, Гендер.Пол, Должности.Должность, Телефоны.Номер_телефона
FROM Гендер INNER JOIN Члены_профсоюза ON Гендер.Код_пола = Члены_профсоюза.Код_пола INNER JOIN Должности ON Члены_профсоюза.Код_должности = Должности.Код_должности INNER JOIN 
              Телефоны ON Члены_профсоюза.Код_ЧП = Телефоны.Код_ЧП