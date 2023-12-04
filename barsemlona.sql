-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 04/12/2023 às 22:59
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `barsemlona`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `contrato`
--

CREATE TABLE `contrato` (
  `id_contrato` int(11) NOT NULL,
  `id_time` int(11) NOT NULL,
  `id_jogadores` int(11) NOT NULL,
  `valor_contrato` double NOT NULL,
  `data_contrato` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `contrato`
--

INSERT INTO `contrato` (`id_contrato`, `id_time`, `id_jogadores`, `valor_contrato`, `data_contrato`) VALUES
(10, 3, 2, 900, '2023-11-29'),
(11, 3, 1, 100000000, '2023-11-30');

-- --------------------------------------------------------

--
-- Estrutura para tabela `divisao`
--

CREATE TABLE `divisao` (
  `id_divisao` int(11) NOT NULL,
  `nome_divisao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `divisao`
--

INSERT INTO `divisao` (`id_divisao`, `nome_divisao`) VALUES
(1, 'Serie A'),
(2, 'Serie B'),
(3, 'Serie C');

-- --------------------------------------------------------

--
-- Estrutura para tabela `jogadores`
--

CREATE TABLE `jogadores` (
  `id_jogadores` int(11) NOT NULL,
  `nome` varchar(100) NOT NULL,
  `data_nascimento` date NOT NULL,
  `posicao` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `jogadores`
--

INSERT INTO `jogadores` (`id_jogadores`, `nome`, `data_nascimento`, `posicao`) VALUES
(1, 'Joazin Kamavinga', '2004-11-26', 'PD'),
(2, 'Cauazin MMLEITE', '2023-11-28', ' LE'),
(5, 'joao paulo da silva ferreira', '2003-07-20', ' MC');

-- --------------------------------------------------------

--
-- Estrutura para tabela `time`
--

CREATE TABLE `time` (
  `id_time` int(11) NOT NULL,
  `nome_time` varchar(100) NOT NULL,
  `id_divisao` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `time`
--

INSERT INTO `time` (`id_time`, `nome_time`, `id_divisao`) VALUES
(1, 'Real Barcelona', 3),
(3, 'Joao perdedor', 3),
(4, 'Barsemlona', 3);

-- --------------------------------------------------------

--
-- Estrutura stand-in para view `view_contratos`
-- (Veja abaixo para a visão atual)
--
CREATE TABLE `view_contratos` (
`id_contrato` int(11)
,`nome_time` varchar(100)
,`nome` varchar(100)
,`valor_contrato` double
,`data_contrato` date
);

-- --------------------------------------------------------

--
-- Estrutura para view `view_contratos`
--
DROP TABLE IF EXISTS `view_contratos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_contratos`  AS SELECT `contrato`.`id_contrato` AS `id_contrato`, `time`.`nome_time` AS `nome_time`, `jogadores`.`nome` AS `nome`, `contrato`.`valor_contrato` AS `valor_contrato`, `contrato`.`data_contrato` AS `data_contrato` FROM ((`contrato` join `time` on(`contrato`.`id_time` = `time`.`id_time`)) join `jogadores` on(`contrato`.`id_jogadores` = `jogadores`.`id_jogadores`)) ;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `contrato`
--
ALTER TABLE `contrato`
  ADD PRIMARY KEY (`id_contrato`),
  ADD KEY `id_jogadores` (`id_jogadores`),
  ADD KEY `id_time` (`id_time`);

--
-- Índices de tabela `divisao`
--
ALTER TABLE `divisao`
  ADD PRIMARY KEY (`id_divisao`);

--
-- Índices de tabela `jogadores`
--
ALTER TABLE `jogadores`
  ADD PRIMARY KEY (`id_jogadores`);

--
-- Índices de tabela `time`
--
ALTER TABLE `time`
  ADD PRIMARY KEY (`id_time`),
  ADD KEY `id_divisao` (`id_divisao`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `contrato`
--
ALTER TABLE `contrato`
  MODIFY `id_contrato` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `divisao`
--
ALTER TABLE `divisao`
  MODIFY `id_divisao` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `jogadores`
--
ALTER TABLE `jogadores`
  MODIFY `id_jogadores` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `time`
--
ALTER TABLE `time`
  MODIFY `id_time` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `contrato`
--
ALTER TABLE `contrato`
  ADD CONSTRAINT `contrato_ibfk_1` FOREIGN KEY (`id_jogadores`) REFERENCES `jogadores` (`id_jogadores`),
  ADD CONSTRAINT `contrato_ibfk_2` FOREIGN KEY (`id_time`) REFERENCES `time` (`id_time`);

--
-- Restrições para tabelas `time`
--
ALTER TABLE `time`
  ADD CONSTRAINT `time_ibfk_1` FOREIGN KEY (`id_divisao`) REFERENCES `divisao` (`id_divisao`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
