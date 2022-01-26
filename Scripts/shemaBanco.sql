-------------------------------------------------------------
--- Produto 
-------------------------------------------------------------
CREATE TABLE Produto (
    [Id]                UNIQUEIDENTIFIER            NOT NULL, 
    [Nome]              VARCHAR(160)                NOT NULL, 
    [Preco]             DECIMAL(7, 3)               NOT NULL, 
    [Descricao]         VARCHAR(160)                NOT NULL
    CONSTRAINT [PK_Produto]
        PRIMARY KEY ([Id])
);

-------------------------------------------------------------
--- Produto 
-------------------------------------------------------------
CREATE TABLE ItemCarrinho (
    [Id]                UNIQUEIDENTIFIER            NOT NULL, 
    [ProdutoId]         UNIQUEIDENTIFIER            NOT NULL, 
    [Qtd]               INTEGER                     NOT NULL, 
    CONSTRAINT [Pk_ItemCarrinho]
        PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_ItemCarrinho_Produto]
        FOREIGN KEY ([ProdutoId])
            REFERENCES [Produto] ([Id])
);

-------------------------------------------------------------
--- Carrinho de compras 
-------------------------------------------------------------
CREATE TABLE CarrinhoDeCompras (
    [Id]            UNIQUEIDENTIFIER            NOT NULL, 
    [ItemId]        UNIQUEIDENTIFIER             NOT NULL,
    CONSTRAINT [PK_CarrinhoDeCompras]
        PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_CarrinhoDeCompras_ItemCarrinho]
        FOREIGN KEY ([ItemId])
            REFERENCES [ItemCarrinho] ([Id])
);

-------------------------------------------------------------
--- Caixa
-------------------------------------------------------------
CREATE TABLE Caixa (
    [Id]                      UNIQUEIDENTIFIER           NOT NULL,  
    [Troco]                   DECIMAL                    NOT NULL,
    [IdCarrinhosDeCompras]    UNIQUEIDENTIFIER           NOT NULL,
    CONSTRAINT [PK_Caixa]
        PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_Caixa_CarrinhoDeCompras]
        FOREIGN KEY ([Id])
            REFERENCES [CarrinhoDeCompras] ([Id])
);

