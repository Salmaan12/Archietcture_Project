use SCDPROJECT

select * from Admin

select * from CreateAccount

select * from CustomerAccount

select * from CreateAccount where AccountNumber = 123456

CREATE PROCEDURE DEPOSITFUND (@DESTID INT, @AMT float)
AS
BEGIN
UPDATE CreateAccount SET OpeningBalance = OpeningBalance+@AMT WHERE AccountNumber=@DESTID
END

select * from CreateAccount
exec DEPOSITFUND 123456,1000
print 'after the exce'
select * from CreateAccount

CREATE PROCEDURE WITHDRAW (@DESTID INT, @WAMT float)
AS
BEGIN
UPDATE CreateAccount SET OpeningBalance = OpeningBalance-@WAMT WHERE AccountNumber=@DESTID
END

exec WITHDRAW 987654321,2000
select * from CreateAccount

CREATE TABLE BillPayment (
	billId int IDENTITY(1,1),
    ConsumerNumber int NOT NULL,
    BillType varchar(255) NOT NULL,
    AccountNum int,
    PRIMARY KEY (ConsumerNumber,BillId),
	Foreign key(AccountNum) references CreateAccount(AccountNumber)
);

select * from BillPayment

select * from Admin