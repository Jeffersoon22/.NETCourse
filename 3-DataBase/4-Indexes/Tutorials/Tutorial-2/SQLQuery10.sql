create table Gift(
	GiftId int primary key,
	[Name] nvarchar(100),
	MinimumOrderPrice int,
	Size nvarchar(max),
	[Weight] int,
	IsFlammable bit
)