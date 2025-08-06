
import { NavLink } from 'react-router-dom';
import healpoint_logo from '../assets/healpoint_logo.png';
const Navbar = () => {
  return (
    <div className="flex">
      <div>
        <img src={healpoint_logo} alt="healppint"/>
      </div>
      <div>
        <NavLink to={'/'}>Home</NavLink>
        <NavLink to={'/'}>Home</NavLink>
      </div>
    </div>
  )
}

export default Navbar