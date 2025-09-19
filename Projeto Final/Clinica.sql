-- Apaga o esquema 'clinica' e todas as tabelas dentro dele (se existirem).
DROP SCHEMA IF EXISTS clinica CASCADE;

-- Cria o esquema 'clinica' novamente.
CREATE SCHEMA clinica;

-- Cria a tabela de pacientes.
CREATE TABLE clinica.pacientes (
    cpf VARCHAR(14) PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    data_nascimento DATE,
    telefone VARCHAR(20)
);

-- Cria a tabela de médicos.
CREATE TABLE clinica.medicos (
    cpf VARCHAR(14) PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    especialidade VARCHAR(100),
    telefone VARCHAR(20)
);

-- Cria a tabela de consultas, sem a coluna 'observacoes'.
CREATE TABLE clinica.consultas (
    id SERIAL PRIMARY KEY,
    paciente_cpf VARCHAR(14) NOT NULL,
    medico_cpf VARCHAR(14) NOT NULL,
    data DATE NOT NULL,
    horario TIME NOT NULL,
    FOREIGN KEY (paciente_cpf) REFERENCES clinica.pacientes(cpf) ON DELETE CASCADE,
    FOREIGN KEY (medico_cpf) REFERENCES clinica.medicos(cpf) ON DELETE CASCADE
);