import { useEffect, useState } from 'react';
import '../Shared/shared.css';

function TabelaPaciente() {
    const [Pacientes, setPaciente] = useState();
    useEffect(() => {
        populatePacienteData();
    }, []);


    const contents = Pacientes === undefined
        ? <p><em>Loading... Please refresh once the ASP.NET backend has started. See <a href="https://aka.ms/jspsintegrationreact">https://aka.ms/jspsintegrationreact</a> for more details.</em></p>

        : <div>
          <h4>Pacientes Aguardando Atendimento</h4>
            <table>
                <thead>
                    <tr>
                        <td>NOME</td>
                        <td>Sexo</td>
                        <td>Telefone</td>
                        <td>Email</td>
                    </tr>
                </thead>
                <tbody>
                    {Pacientes.map(paciente =>
                        <tr key={paciente.id}>
                            <td>{paciente.nome}</td>
                            <td>{paciente.sexo}</td>
                            <td>{paciente.telefone}</td>
                            <td>{paciente.email}</td>
                        </tr>
                    )}                    
                </tbody>
            </table>
        </div> 

    return (
        <div>
            {contents}
        </div>
    );
    async function populatePacienteData() {
        let url = "https://localhost:7230/api/Paciente";

        const response = await fetch(url, { mode: 'cors' });
        const data = await response.json();
        console.log(data);

        setPaciente(data);
    }
}

export default TabelaPaciente;