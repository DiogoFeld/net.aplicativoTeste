import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.jsx'
import FormPaciente from '../Components/formPaciente.jsx'
import TabelaPaciente from '../Components/TabelaPaciente.jsx'

//createRoot(document.getElementById('root')).render(
//    <StrictMode>
//        <App />
//    </StrictMode>,
//)
createRoot(document.getElementById('formPaciente')).render(
    <StrictMode>
        <FormPaciente />
    </StrictMode>,
)

createRoot(document.getElementById('tabelaPaciente')).render(
    <StrictMode>
        <TabelaPaciente />
    </StrictMode>,
)
