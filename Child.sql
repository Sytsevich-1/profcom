USE [E:\MAKS\���������\�����������\2 ����\2 �������\��\����������� ����\PROFCOM_DB.MDF]
GO
/****** Object:  StoredProcedure [dbo].[Person]    Script Date: 13.05.2022 23:40:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Person]
AS
	SET NOCOUNT ON;
SELECT �����_���������.���_��, �����_���������.�������, �����_���������.���, �����_���������.��������, ����.������� AS Expr1, ����.��� AS Expr2, ����.�������� AS Expr3, ����.����_��������, ������.���
FROM ������ INNER JOIN ���� ON ������.���_���� = ����.���_���� INNER JOIN �����_��������� ON ������.���_���� = �����_���������.���_���� INNER JOIN
                         ����_�������� ON ����.���_���� = ����_��������.���_���� AND �����_���������.���_�� = ����_��������.���_��