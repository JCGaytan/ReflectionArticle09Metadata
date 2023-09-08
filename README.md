# Extending Reflection with Custom Metadata Console Application

## Table of Contents

- [Overview](#overview)
- [Key Concepts](#key-concepts)
- [Getting Started](#getting-started)
- [License](#license)

## Overview

This console application demonstrates key concepts related to extending reflection with custom metadata. It covers the following aspects:

- Creating custom attributes and annotations.
- Building a metadata repository using reflection.
- Implementing custom metadata providers.
- Integration with third-party frameworks and libraries (demonstrated with AutoMapper).

## Key Concepts

### Creating Custom Attributes and Annotations

The application defines a custom attribute `MyMetadataAttribute`, which can be applied to classes and methods. These attributes serve as custom metadata annotations.

### Building a Metadata Repository Using Reflection

The `MetadataRepository` class displays metadata attributes applied to a given type, including class-level and method-level attributes. Additionally, it lists the properties of the type using reflection.

### Implementing Custom Metadata Providers

The application includes a `MetadataProvider` class responsible for extracting custom metadata descriptions from members (classes or methods) using reflection.

### Integration with Third-Party Frameworks and Libraries

Although not a direct integration, the code demonstrates the potential for integrating custom metadata with third-party libraries. We use AutoMapper to map custom metadata attributes between objects, showcasing how custom metadata can be incorporated into various third-party libraries and frameworks.

## Getting Started

1. Clone this repository.
2. Build and run the console application in your development environment.

## License

This project is licensed under the MIT License - see the [LICENSE.txt](LICENSE.txt) file for details.

---

#### Spanish

# Aplicación de Consola para Extender Reflection con Metadatos Personalizados

## Tabla de Contenidos

- [Visión General](#visión-general)
- [Conceptos Clave](#conceptos-clave)
- [Empezar](#empezar)
- [Licencia](#licencia)

## Visión General

Esta aplicación de consola demuestra conceptos clave relacionados con la extensión de reflection con metadatos personalizados. Cubre los siguientes aspectos:

- Creación de atributos y anotaciones personalizados.
- Construcción de un repositorio de metadatos utilizando reflection.
- Implementación de proveedores de metadatos personalizados.
- Integración con marcos y bibliotecas de terceros (demostrado con AutoMapper).

## Conceptos Clave

### Creación de Atributos y Anotaciones Personalizados

La aplicación define un atributo personalizado llamado `MyMetadataAttribute`, que se puede aplicar a clases y métodos. Estos atributos sirven como anotaciones de metadatos personalizados.

### Construcción de un Repositorio de Metadatos Utilizando Reflection

La clase `MetadataRepository` muestra los atributos de metadatos aplicados a un tipo dado, incluyendo atributos a nivel de clase y método. Además, lista las propiedades del tipo utilizando reflection.

### Implementación de Proveedores de Metadatos Personalizados

La aplicación incluye una clase `MetadataProvider` encargada de extraer descripciones de metadatos personalizados de miembros (clases o métodos) utilizando reflection.

### Integración con Marcos y Bibliotecas de Terceros

Aunque no se trata de una integración directa, el código demuestra el potencial de integrar metadatos personalizados con bibliotecas de terceros. Utilizamos AutoMapper para mapear atributos de metadatos personalizados entre objetos, mostrando cómo los metadatos personalizados pueden incorporarse en varias bibliotecas y marcos de terceros.

## Empezar

1. Clona este repositorio.
2. Compila y ejecuta la aplicación de consola en tu entorno de desarrollo.

## Licencia

Este proyecto está bajo la Licencia MIT - consulta el archivo [LICENSE.txt](LICENSE.txt) para obtener detalles.

---

#### French

# Application Console d'Extension de Reflection avec des Métadonnées Personnalisées

## Table des Matières

- [Aperçu](#aperçu)
- [Concepts Clés](#concepts-clés)
- [Pour Commencer](#pour-commencer)
- [Licence](#licence)

## Aperçu

Cette application console présente les concepts clés liés à l'extension de reflection avec des métadonnées personnalisées. Elle couvre les aspects suivants :

- Création d'attributs et d'annotations personnalisés.
- Construction d'un référentiel de métadonnées à l'aide de la réflexion.
- Mise en œuvre de fournisseurs de métadonnées personnalisées.
- Intégration avec des cadres et des bibliothèques tierces (démontrée avec AutoMapper).

## Concepts Clés

### Création d'Atributs et d'Anotations Personnalisés

L'application définit un attribut personnalisé `MyMetadataAttribute`, qui peut être appliqué aux classes et aux méthodes. Ces attributs servent d'annotations de métadonnées personnalisées.

### Construction d'un Répertoire de Métadonnées en Utilisant la Réflexion

La classe `MetadataRepository` affiche les attributs de métadonnées appliqués à un type donné, y compris les attributs au niveau de la classe et de la méthode. De plus, elle répertorie les propriétés du type à l'aide de la réflexion.

### Implémentation de Fournisseurs de Métadonnées Personnalisées

L'application inclut une classe `MetadataProvider` chargée d'extraire les descriptions de métadonnées personnalisées à partir de membres (classes ou méthodes) en utilisant la réflexion.

### Intégration avec des Cadres et des Bibliothèques Tiers

Bien que ce ne soit pas une intégration directe, le code montre le potentiel d'intégrer des métadonnées personnalisées avec des bibliothèques tierces. Nous utilisons AutoMapper pour mapper les attributs de métadonnées personnalisées entre des objets, montrant comment les métadonnées personnalisées peuvent être intégrées dans diverses bibliothèques et cadres tiers.

## Pour Commencer

1. Clonez ce référentiel.
2. Compilez et exécutez l'application console dans votre environnement de développement.

## Licence

Ce projet est sous licence MIT - consultez le fichier [LICENSE.txt](LICENSE.txt) pour plus de détails.
