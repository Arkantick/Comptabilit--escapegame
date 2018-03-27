-- phpMyAdmin SQL Dump
-- version 4.2.12deb2+deb8u2
-- http://www.phpmyadmin.net
--
-- Client :  localhost
-- Généré le :  Ven 15 Décembre 2017 à 14:09
-- Version du serveur :  5.7.20
-- Version de PHP :  5.6.30-0+deb8u1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `escapegame`
--

-- --------------------------------------------------------

--
-- Structure de la table `Creneaux`
--

CREATE TABLE IF NOT EXISTS `Creneaux` (
`id` int(11) NOT NULL,
  `heureDebut` int(11) NOT NULL,
  `nombreCreneaux` int(11) NOT NULL,
  `jour` varchar(45) NOT NULL,
  `site` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `Joueurs`
--

CREATE TABLE IF NOT EXISTS `Joueurs` (
`id` int(11) NOT NULL,
  `nom` varchar(45) NOT NULL,
  `prenom` varchar(45) NOT NULL,
  `dateNaissance` date NOT NULL,
  `dateInscription` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `credit` float NOT NULL DEFAULT '0',
  `mail` varchar(100) NOT NULL DEFAULT 'Email non fournis',
  `pseudo` varchar(45) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Joueurs`
--

INSERT INTO `Joueurs` (`id`, `nom`, `prenom`, `dateNaissance`, `dateInscription`, `credit`, `mail`, `pseudo`) VALUES
(1, 'Gueyraud', 'Guillaume', '2015-10-20', '2017-10-20 00:00:00', 93, 'Guillaume@hotmail.fr', 'guigui'),
(2, 'Dutartre', 'Thomas', '2016-10-20', '2017-10-20 00:00:00', 0, 'thomas@hotmail.fr', 'dudu04'),
(3, 'Megevand', 'Fabien', '2015-10-20', '2017-10-20 00:00:00', 0, 'Fabien@gmail.com', 'meme'),
(4, 'Ghazarian', 'Ludovic', '2014-10-20', '2017-10-20 00:00:00', 157, 'ludo@france3.fr', 'lulu'),
(5, 'Clerc', 'Corentinn', '2013-10-20', '2017-10-20 00:00:00', 15, 'Corentin@hotmail.fr', 'cocoo'),
(6, 'Bommart', 'Cedric', '2012-10-20', '2017-10-20 00:00:00', 13, 'Cde@hotmail.fr', 'boboo'),
(7, 'Dupont', 'Benjamin', '2011-10-20', '2017-10-20 00:00:00', 0, 'thierry@hotmail.fr', 'benjii'),
(8, 'Ovitch', 'William', '2010-10-20', '2017-10-20 00:00:00', 50, 'Willy@hotmail.fr', 'wiwiii'),
(9, 'Barbier', 'Ethann', '2009-10-20', '2017-10-20 00:00:00', 15, 'Ethan@gmail.com', 'baba'),
(10, 'Dragol', 'Armand', '2008-10-20', '2017-10-20 00:00:00', 15, 'Armand@hotmail.fr', 'dradraa'),
(11, 'De Bergerac', 'Cyrano', '2000-10-20', '2017-10-20 00:00:00', 0, 'Cyrano@hotmail.fr', 'cycyy'),
(12, 'Martinez', 'Clement', '1990-02-04', '2017-12-07 11:06:19', 0, 'cle@hotmail.fr', 'clecle'),
(13, 'Ballester', 'Laurie', '1990-05-05', '2017-12-14 11:30:44', 0, 'laulau@hotmail.fr', 'laulauu'),
(14, 'Laporte', 'Loic', '1985-05-04', '2017-12-14 11:33:44', 0, 'lfsdfsdfsdf@hotmail.fr', 'lolo'),
(15, 'Roselmac', 'Harry', '1990-05-04', '2017-12-14 15:44:22', 0, 'harry@hotmail.fr', 'haryryr');

-- --------------------------------------------------------

--
-- Structure de la table `JoueursParties`
--

CREATE TABLE IF NOT EXISTS `JoueursParties` (
  `joueur` int(11) NOT NULL,
  `partie` int(11) NOT NULL,
  `avis` varchar(1000) DEFAULT 'Aucun avis laissé'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Contenu de la table `JoueursParties`
--

INSERT INTO `JoueursParties` (`joueur`, `partie`, `avis`) VALUES
(1, 7, 'Aucun avis laissé'),
(2, 5, 'Aucun avis laissé'),
(2, 7, 'Aucun avis laissé'),
(2, 8, 'Aucun avis laissé'),
(4, 3, 'Aucun avis laissé'),
(4, 6, 'Aucun avis laissé'),
(5, 3, 'Aucun avis laissé'),
(5, 4, 'Aucun avis laissé'),
(6, 3, 'Aucun avis laissé'),
(6, 4, 'Aucun avis laissé'),
(6, 5, 'Aucun avis laissé'),
(6, 9, 'Aucun avis laissé'),
(7, 8, 'Aucun avis laissé'),
(9, 3, 'Aucun avis laissé'),
(9, 6, 'Aucun avis laissé'),
(9, 8, 'Aucun avis laissé'),
(10, 3, 'Aucun avis laissé'),
(11, 9, 'Aucun avis laissé'),
(12, 7, 'Aucun avis laissé');

-- --------------------------------------------------------

--
-- Structure de la table `niveauxAccreditation`
--

CREATE TABLE IF NOT EXISTS `niveauxAccreditation` (
`niveaux` int(11) NOT NULL,
  `libelle` varchar(45) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `niveauxAccreditation`
--

INSERT INTO `niveauxAccreditation` (`niveaux`, `libelle`) VALUES
(1, 'Administrateur'),
(2, 'Secrétaire'),
(3, 'Direction'),
(4, 'Technicien');

-- --------------------------------------------------------

--
-- Structure de la table `Obstacles`
--

CREATE TABLE IF NOT EXISTS `Obstacles` (
`id` int(11) NOT NULL,
  `nom` varchar(45) NOT NULL,
  `type` varchar(45) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Obstacles`
--

INSERT INTO `Obstacles` (`id`, `nom`, `type`) VALUES
(1, 'test', 'type'),
(55, 'mat', 'shugi');

-- --------------------------------------------------------

--
-- Structure de la table `ObstaclesParties`
--

CREATE TABLE IF NOT EXISTS `ObstaclesParties` (
  `obstacle` int(11) NOT NULL,
  `partie` int(11) NOT NULL,
  `position` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Structure de la table `Parties`
--

CREATE TABLE IF NOT EXISTS `Parties` (
`id` int(11) NOT NULL,
  `joueurPayeur` int(11) NOT NULL,
  `debut` datetime NOT NULL,
  `fin` datetime NOT NULL,
  `salle` int(11) NOT NULL,
  `prix` float NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Parties`
--

INSERT INTO `Parties` (`id`, `joueurPayeur`, `debut`, `fin`, `salle`, `prix`) VALUES
(3, 9, '2017-12-04 00:00:00', '2017-12-10 00:00:00', 1, 250),
(4, 6, '2017-12-04 00:00:00', '2017-12-05 00:00:00', 1, 100),
(5, 6, '2017-12-12 00:00:00', '2017-12-14 00:00:00', 1, 15),
(6, 9, '2017-12-12 00:00:00', '2017-12-05 00:00:00', 2, 10),
(7, 2, '2017-12-11 00:00:00', '2017-12-11 00:00:00', 2, 10),
(8, 9, '2017-12-10 00:00:00', '2017-12-13 00:00:00', 1, 6),
(9, 6, '2017-12-13 00:00:00', '2017-12-14 00:00:00', 1, 999);

-- --------------------------------------------------------

--
-- Structure de la table `Personnel`
--

CREATE TABLE IF NOT EXISTS `Personnel` (
`id` int(11) NOT NULL,
  `identifiant` varchar(45) NOT NULL,
  `mdp` varchar(45) NOT NULL,
  `accreditation` int(11) NOT NULL,
  `site` int(11) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Personnel`
--

INSERT INTO `Personnel` (`id`, `identifiant`, `mdp`, `accreditation`, `site`) VALUES
(1, 'admin', 'root', 1, 1),
(2, 'thomas', 'root', 2, 2),
(3, 'fabien', 'root', 4, 3),
(4, 'guillaume', 'root', 3, 4);

-- --------------------------------------------------------

--
-- Structure de la table `Salles`
--

CREATE TABLE IF NOT EXISTS `Salles` (
`id` int(11) NOT NULL,
  `site` int(11) NOT NULL,
  `nom` varchar(45) NOT NULL,
  `capacite` int(11) NOT NULL,
  `theme` varchar(45) NOT NULL DEFAULT 'Theme non définit'
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Salles`
--

INSERT INTO `Salles` (`id`, `site`, `nom`, `capacite`, `theme`) VALUES
(1, 1, 'Salle A', 10, 'Tortank'),
(2, 1, 'Salle D', 10, 'Harry Potter'),
(5, 1, 'Salle C', 10, 'Theme non défini'),
(6, 1, 'Salle B', 10, 'St-Michou'),
(10, 1, 'Salle A', 10, 'Theme non définit'),
(20, 1, 'Salle B', 10, 'Theme non définit');

-- --------------------------------------------------------

--
-- Structure de la table `Sites`
--

CREATE TABLE IF NOT EXISTS `Sites` (
`id` int(11) NOT NULL,
  `adresse` varchar(45) NOT NULL,
  `codePostal` int(11) NOT NULL,
  `ville` varchar(45) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Sites`
--

INSERT INTO `Sites` (`id`, `adresse`, `codePostal`, `ville`) VALUES
(1, '2 rue de la paix', 74000, 'Annecy'),
(2, '3 rue du style', 74200, 'Thonon les bain'),
(3, '1 chemin du magasin', 74130, 'Bonneville'),
(4, '1 faubourg des trucs', 74400, 'Chamonix-Mont-Blanc');

-- --------------------------------------------------------

--
-- Structure de la table `Transactions`
--

CREATE TABLE IF NOT EXISTS `Transactions` (
`id` int(11) NOT NULL,
  `joueur` int(11) NOT NULL,
  `valeur` int(11) NOT NULL,
  `date` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Contenu de la table `Transactions`
--

INSERT INTO `Transactions` (`id`, `joueur`, `valeur`, `date`) VALUES
(1, 3, 50, '2017-10-20 00:00:00'),
(2, 4, -20, '2017-10-20 00:00:00'),
(3, 4, 60, '2017-10-20 00:00:00'),
(4, 1, 80, '2017-10-20 00:00:00'),
(5, 2, 150, '2017-10-20 00:00:00'),
(6, 5, -100, '2017-10-20 00:00:00'),
(7, 6, 300, '2017-10-20 00:00:00'),
(8, 7, -20, '2017-10-20 00:00:00'),
(9, 1, 10, '2017-12-15 13:57:07'),
(10, 5, 15, '2017-12-15 13:57:36'),
(11, 1, 15, '2017-12-15 13:59:19');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `Creneaux`
--
ALTER TABLE `Creneaux`
 ADD PRIMARY KEY (`id`), ADD KEY `site_idx` (`site`);

--
-- Index pour la table `Joueurs`
--
ALTER TABLE `Joueurs`
 ADD PRIMARY KEY (`id`), ADD UNIQUE KEY `pseudo_UNIQUE` (`pseudo`);

--
-- Index pour la table `JoueursParties`
--
ALTER TABLE `JoueursParties`
 ADD PRIMARY KEY (`joueur`,`partie`), ADD KEY `parties_idx` (`partie`);

--
-- Index pour la table `niveauxAccreditation`
--
ALTER TABLE `niveauxAccreditation`
 ADD PRIMARY KEY (`niveaux`);

--
-- Index pour la table `Obstacles`
--
ALTER TABLE `Obstacles`
 ADD PRIMARY KEY (`id`);

--
-- Index pour la table `ObstaclesParties`
--
ALTER TABLE `ObstaclesParties`
 ADD PRIMARY KEY (`obstacle`,`partie`), ADD KEY `partie_idx` (`partie`);

--
-- Index pour la table `Parties`
--
ALTER TABLE `Parties`
 ADD PRIMARY KEY (`id`), ADD KEY `joueurpayer_idx` (`joueurPayeur`), ADD KEY `salle454_idx` (`salle`);

--
-- Index pour la table `Personnel`
--
ALTER TABLE `Personnel`
 ADD PRIMARY KEY (`id`), ADD UNIQUE KEY `identifiant_UNIQUE` (`identifiant`), ADD KEY `accreditation_idx` (`accreditation`), ADD KEY `site_idx` (`site`);

--
-- Index pour la table `Salles`
--
ALTER TABLE `Salles`
 ADD PRIMARY KEY (`id`), ADD KEY `site45645_idx` (`site`);

--
-- Index pour la table `Sites`
--
ALTER TABLE `Sites`
 ADD PRIMARY KEY (`id`);

--
-- Index pour la table `Transactions`
--
ALTER TABLE `Transactions`
 ADD PRIMARY KEY (`id`), ADD KEY `joueur_idx` (`joueur`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `Creneaux`
--
ALTER TABLE `Creneaux`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT pour la table `Joueurs`
--
ALTER TABLE `Joueurs`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT pour la table `niveauxAccreditation`
--
ALTER TABLE `niveauxAccreditation`
MODIFY `niveaux` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT pour la table `Obstacles`
--
ALTER TABLE `Obstacles`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=56;
--
-- AUTO_INCREMENT pour la table `Parties`
--
ALTER TABLE `Parties`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT pour la table `Personnel`
--
ALTER TABLE `Personnel`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT pour la table `Salles`
--
ALTER TABLE `Salles`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT pour la table `Sites`
--
ALTER TABLE `Sites`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT pour la table `Transactions`
--
ALTER TABLE `Transactions`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=12;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `Creneaux`
--
ALTER TABLE `Creneaux`
ADD CONSTRAINT `siteConcerne` FOREIGN KEY (`site`) REFERENCES `Sites` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `JoueursParties`
--
ALTER TABLE `JoueursParties`
ADD CONSTRAINT `joueurConcerne` FOREIGN KEY (`joueur`) REFERENCES `Joueurs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `partieConcerne` FOREIGN KEY (`partie`) REFERENCES `Parties` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `ObstaclesParties`
--
ALTER TABLE `ObstaclesParties`
ADD CONSTRAINT `obstacles` FOREIGN KEY (`obstacle`) REFERENCES `Obstacles` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `partieRelie` FOREIGN KEY (`partie`) REFERENCES `Parties` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `Parties`
--
ALTER TABLE `Parties`
ADD CONSTRAINT `joueurpayeur` FOREIGN KEY (`joueurPayeur`) REFERENCES `Joueurs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `salle454` FOREIGN KEY (`salle`) REFERENCES `Salles` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `Personnel`
--
ALTER TABLE `Personnel`
ADD CONSTRAINT `accreditation` FOREIGN KEY (`accreditation`) REFERENCES `niveauxAccreditation` (`niveaux`) ON DELETE NO ACTION ON UPDATE NO ACTION,
ADD CONSTRAINT `siteDeTravail` FOREIGN KEY (`site`) REFERENCES `Sites` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `Salles`
--
ALTER TABLE `Salles`
ADD CONSTRAINT `site45645` FOREIGN KEY (`site`) REFERENCES `Sites` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Contraintes pour la table `Transactions`
--
ALTER TABLE `Transactions`
ADD CONSTRAINT `Joueur_Concerne` FOREIGN KEY (`joueur`) REFERENCES `Joueurs` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
