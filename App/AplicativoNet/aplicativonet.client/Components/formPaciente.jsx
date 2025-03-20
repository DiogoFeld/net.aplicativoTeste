import React, { useState } from 'react';
import ReactDOM from 'react-dom/client';
import '../Shared/shared.css';

function FormPaciente() {
    const [nome, setName] = useState('');
    const [email, setEmail] = useState('');
    const [telefone, setFone] = useState('');
    const [sexo, setSexo] = useState('');

    const handleSubmit = async (event) => {
        event.preventDefault(); // Evita que a página seja recarregada ao submeter o formulário
        alert(`Formulário enviado!`);


        const formData = {
            nome,
            email,
            telefone,
            sexo
        };

        try {
            // Envia os dados via POST para o servidor
            const response = await fetch("https://localhost:7230/api/Paciente", {
                method: 'POST',
                headers: {
                    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                    'Content-Type': 'application/json;charset=utf-8',
                },
                mode: 'cors',
                body: JSON.stringify(formData), // Envia os dados do formulário como JSON

            });
            if (response.ok) {
                alert('Formulário enviado com sucesso!');
                // Limpa o formulário após o envio bem-sucedido
                setName('');
                setEmail('');
                setFone('');
                setSexo('');
            } else {
                alert('Erro ao enviar o formulário.');
            }
        } catch (error) {
            console.error('Erro ao enviar os dados:', error);
            alert('Erro na conexão com o servidor.');
        }
    };


    const closeModal = () => {
        // Remove a classe 'show' do modal
        const modalOverlay = document.getElementById('modalOverlay');
        modalOverlay.classList.remove('show');
    };


    return (

        <div className="modal-overlay" id="modalOverlay">
            <div className="modal">
                <button className="close-btn" onClick={closeModal}>&times;</button>
                <h2>Registro de Pacientes</h2>
                <form onSubmit={handleSubmit}>
                    <div className="form-group">
                        <label htmlFor="nome">Nome:</label>
                        <input
                            type="text"
                            value={nome}
                            onChange={(e) => setName(e.target.value)}
                        />
                    </div>

                    <div className="form-group">
                        <label htmlFor="email">Email:</label>
                        <input
                            type="text"
                            value={email}
                            onChange={(e) => setEmail(e.target.value)}
                        />
                    </div>

                    <div className="form-group">
                        <label htmlFor="senha">Sexo:</label>
                        <input
                            type="text"
                            value={sexo}
                            onChange={(e) => setSexo(e.target.value)}
                        />
                    </div>

                    <div className="form-group">
                        <label htmlFor="senha">Telefone:</label>
                        <input
                            type="text"
                            value={telefone}
                            onChange={(e) => setFone(e.target.value)}
                        />
                    </div>

                    <div className="form-group">
                        <button type="submit">Enviar</button>
                    </div>
                </form>
            </div>
        </div>
    );
}



export default FormPaciente;