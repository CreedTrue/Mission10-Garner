import logo from './bowling-logo.jpg';

// A header for the Web page that explains its purpose
function Header() {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img
          src={logo}
          alt="logo"
          className="logo"
          style={{ width: '200px', height: '200px' }}
        />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">Presenting Our World Famous Bowlers!</h1>
      </div>
    </header>
  );
}

export default Header;
