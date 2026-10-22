-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 22/10/2026 às 13:31
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bdtrax`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `funcionario`
--

CREATE TABLE `funcionario` (
  `Codfun` int(11) NOT NULL,
  `Nome` varchar(60) NOT NULL,
  `CPF` varchar(15) NOT NULL,
  `Ender` varchar(70) NOT NULL,
  `Cidade` varchar(30) NOT NULL,
  `Estado` varchar(2) NOT NULL,
  `Tel` varchar(15) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Cargo` varchar(50) NOT NULL,
  `Dataadm` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `pagemento`
--

CREATE TABLE `pagemento` (
  `Codpg` int(11) NOT NULL,
  `Funcionario` varchar(60) NOT NULL,
  `VSM` float NOT NULL,
  `NHT` int(11) NOT NULL,
  `ND` int(11) NOT NULL,
  `NHE` int(11) NOT NULL,
  `VHT` float NOT NULL,
  `VD` float NOT NULL,
  `VHET` float NOT NULL,
  `VRHE` float NOT NULL,
  `SB` float NOT NULL,
  `SM` float NOT NULL,
  `IR` float NOT NULL,
  `SL` float NOT NULL,
  `Gratificacao` float NOT NULL,
  `SR` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `funcionario`
--
ALTER TABLE `funcionario`
  ADD PRIMARY KEY (`Codfun`);

--
-- Índices de tabela `pagemento`
--
ALTER TABLE `pagemento`
  ADD PRIMARY KEY (`Codpg`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `funcionario`
--
ALTER TABLE `funcionario`
  MODIFY `Codfun` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `pagemento`
--
ALTER TABLE `pagemento`
  MODIFY `Codpg` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
